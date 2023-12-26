
int led = 13;
int x = 0;

int button = 3;
int sinal_button = 0;

int button1 = 8;
int sinal_button1 = 0;

void setup() {
  // put your setup code here, to run once:.
  Serial.begin(9600); // Inicia a comunicação serial..

  pinMode(led, OUTPUT);
  pinMode(button, INPUT_PULLUP);

  pinMode(button1, INPUT_PULLUP);
}

  // put your main code here, to run repeatedly:
void loop() {

  sinal_button = digitalRead(button);
  sinal_button1 = digitalRead(button1);

  if (sinal_button == LOW && sinal_button1 == HIGH) {
    Serial.println("botao01Pressionado");
    digitalWrite(led, HIGH);
  }
  else if(sinal_button1 == LOW && sinal_button == HIGH){
    Serial.println("botao02Pressionado");
    digitalWrite(led, HIGH);
    
  }
   else {
    digitalWrite(led, LOW);
    //Muito importante pra não enviar as strings anteriores continuamente, e o programa poder rodar independentemente, oque evita o programa não colar no inicio a espera do input pra receber a string que quer nesse caso distraimo ele com outra garota, pra não pensar muito kkkk
    Serial.println("botõesNãoPressionados");
  }


  /*
     for(int vezes = 0; vezes < 10; vezes++){
      digitalWrite(led, HIGH);
      delay(200);
      digitalWrite(led, LOW);
      delay(200);
     }

     for(int vezes = 0; vezes < 5; vezes++){
      digitalWrite(led, HIGH);
      delay(1000);
      digitalWrite(led, LOW);
      delay(1000);
     }

     while(x < 200){
      digitalWrite(led, HIGH);
      delay(200);
      digitalWrite(led, LOW);
      delay(200);

          x += 1;
     }
     */
}
