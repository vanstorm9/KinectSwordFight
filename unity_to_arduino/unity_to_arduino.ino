// the setup function runs once when you press reset or power the board
int val = 0;
void setup() {
  // initialize digital pin 13 as an output.
  Serial.begin(9600);   
  Serial.println("Commencing start-up");
}

// the loop function runs over and over again forever
void loop() {
  if(Serial.available())
  {
     val = Serial.read();
     Serial.println(val);
  
  }
  
}
