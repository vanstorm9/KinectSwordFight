#include <Wire.h>
#include <Adafruit_MotorShield.h>
#include "utility/Adafruit_PWMServoDriver.h"

Adafruit_MotorShield AFMS = Adafruit_MotorShield(0x61); 

// Connect a stepper motor with 200 steps per revolution (1.8 degree)
// to motor port #2 (M3 and M4)
Adafruit_DCMotor* grootMotor1 = AFMS.getMotor(1);
Adafruit_StepperMotor* grootMotor2 = AFMS.getStepper(200, 2);

int val = 0;
/*
int audio = 0;yy
int strobe = 4;
int reset = 7;
int vol;
const int setSize = 30;
int set[setSize];
int total;
int direct = 1;
int mean;
int switch_count = 0;
int number;
int readed; //we got fustrated so its spelled wrong on perpose
*/

void setup() {
  delay(1000);
  Serial.begin(9600);           // set up Serial library at 9600 bps
  Serial.println("I am GROOOOOT!!");

  AFMS.begin();  // create with the default frequency 1.6KHz

  grootMotor1->setSpeed(100);
  //grootMotor1 -> run(FORWARD);
  //grootMotor1 -> run(RELEASE);
  //grootMotor2->setSpeed(55);
  /**analogReference(DEFAULT);
  pinMode(audio, INPUT);
  pinMode(strobe, OUTPUT);
  pinMode(reset, OUTPUT);
  digitalWrite(reset, LOW);
  digitalWrite(strobe, HIGH);*/
}

void loop() {
  if(Serial.available())
  {
    val = Serial.read();
    grootMotor1->setSpeed(100);
    grootMotor1 -> run(FORWARD);
    //grootMotor1 -> run(RELEASE);
    Serial.println(":D  :D  :D");
    //Serial.println(val);
  } else {
    val = 0;
    grootMotor1->setSpeed(10);
    grootMotor1 -> run(BACKWARD);
    //grootMotor1 -> run(RELEASE);
    Serial.println("Nope");
    //Serial.println(val);
  }
  delay(50);
  
  
 /*       
	for (int i = 0; i < setSize; i = (i + 1) % setSize)
	{      
//                number = Serial.read();
//                Serial.println(number);            
                
           while(Serial.available())
           {
               delay(200 * (1/ Serial.available()));
                   Serial.read();

           }
                
		//call the vol function & return vol
		getVolume();
		
		total = 0;
		set[i] = vol;

//                Serial.print(set[i]);
//                Serial.print(" ");

		for(int j = 0; j < setSize; j++)
		{
			total += set[j];
		}
		
		mean = total / setSize;
                
//                Serial.println(mean);
		
		if (set[i] > 2*mean && switch_count > 6)
		{
                        switch_count = 0;
			if ( direct == 1)
			{
				direct = 2;
                          
			}
			else
			{
				direct = 1;	
			}
		}
		
		grootMotor1 -> step(1, direct, SINGLE);
                grootMotor2 -> step(1, direct, SINGLE);
                switch_count++;	
	}
*/
}
		

/*
void getVolume()
{
	digitalWrite(reset, HIGH);
	digitalWrite(reset, LOW);
	vol = 0;

	for ( int j = 0; j < 3; j++)
	{
		digitalWrite(strobe, LOW);
		delayMicroseconds(30);
		if(j != 0)
		{
			vol = vol + analogRead(audio);
		}
		digitalWrite(strobe, HIGH);
	}
      
//      Serial.println("red");
}
*/
