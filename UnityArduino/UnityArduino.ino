// Arduino to Unity Bridge

// Connect three sensors of any type, send their values to print
int one = 0;
int two = 0;
int tre = 0;

void setup() {
  Serial.begin(9600);
  pinMode(7, INPUT);
  pinMode(8, INPUT);
}

void loop() {
  one = analogRead(A0);
  two = digitalRead(7);
  tre = digitalRead(8);
  

  Serial.print(one);
  Serial.print(",");
  Serial.print(two);
  Serial.print(",");
  Serial.println(tre);
  delay(10);

}
