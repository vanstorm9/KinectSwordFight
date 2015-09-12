// the setup function runs once when you press reset or power the board

// This is a sample unity to arduino script in which
// LED 13 turns on and off if you click on a cube
// Tested and it works :D

int val = 0;
bool on = false;
void setup() {
  Serial.begin(9600);   
  pinMode(13, OUTPUT);
  Serial.println("Commencing start-up");
}

// the loop function runs over and over again forever
void loop() {
  //digitalWrite(13, LOW);
  if(Serial.available())
  {
    
     if(on == false)
     {
        digitalWrite(13, HIGH); 
        on = true; 
     } else {
        digitalWrite(13, LOW);
        on = false;
     }
     val = Serial.read();
     Serial.println(val);
  
  }
  
}
