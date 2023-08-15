#include <Ezo_i2c.h>       //include the EZO I2C library from https://github.com/Atlas-Scientific/Ezo_I2c_lib
#include <Wire.h>          //include arduinos i2c library
#include <Ezo_i2c_util.h>  //brings in common print statements

// pump variable
bool pumpIsRunning = false;
#define intPumpPin 6

// sensors object
Ezo_board PH = Ezo_board(99, "PH");
Ezo_board EC = Ezo_board(100, "EC");
Ezo_board T = Ezo_board(102, "T");
Ezo_board Clr = Ezo_board(112, "Clr");
String Turbidity;
byte perintah[9] = { 0x08, 0x03, 0x00, 0x00, 0x00, 0x02, 0xC4, 0x92 };  // data to send for reading Turbidity sensor
float mix;

//#define S Serial1  // Serial if using Leonardo
#include <SoftwareSerial.h>  // Serial if using uno
SoftwareSerial S(4, 5);


void setup() {
  Serial.begin(9600);  // Set the hardware serial port to 9600
  S.begin(9600);       //set baudrates for communication with turbidity sensors
  while (!Serial)
    ;            // Leonardo-type arduinos need this to be able to write to the serial port in setup()
  Wire.begin();  // enable I2C port.
}
unsigned long timer = 0;  // timer for showing flowrate data
void loop() {

  readSensors();
  sendData();
  delay(1000);
}

void readSensors() {

  PH.send_read_cmd();
  EC.send_read_cmd();
  T.send_read_cmd();
  Clr.send_read_cmd();
  delay(1000);
  PH.receive_read_cmd();
  EC.receive_read_cmd();
  T.receive_read_cmd();
  Clr.receive_read_cmd();
  readTurbidity();
}
void readTurbidity() {
  byte buf[9] = {};
  S.write(perintah, 9);
  S.readBytes(buf, 9);
  // for (int i = 0; i < 9; i++) {
  //   Serial.print(buf[i], HEX);
  //   Serial.print(" ");
  // }
  // Serial.println();

  for (int j = 3; j < 7; j++) {     // switch data direction
    ((byte*)&mix)[6 - j] = buf[j];  // casting using Big Endian so for array float use data from j[3] to j[0], so j[3-(3-j)] = j[6-j]
    char buff[10];
    dtostrf(mix, 4, 4, buff);  // convert float to string with 6 decimal
    Turbidity = buff;
  }
}
//=================================Communication===========================================

void sendData() {
  String dt =
    "#" +
    String(PH.get_last_received_reading()) + "#" + 
    Clr.get_last_received_readings() + "#" + 
    String(T.get_last_received_reading()) + "#" + 
    String(EC.get_last_received_reading()) + "#" + 
    Turbidity + "#";
  //Serial.println(dt.length());
  Serial.println(dt);
}
