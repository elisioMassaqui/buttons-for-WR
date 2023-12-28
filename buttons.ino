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
    Serial.println("botoesNaoPressionados");
  }

 if (Serial.available() > 0) {
    char comando = Serial.read();  // Lê o comando da porta serial

    // Verifica o comando recebido e executa a ação correspondente
    switch (comando) {
      case 'A':
        piscarLedA();  // Chama a função para piscar o LED
        break;
      case 'B':
        piscarLedB();
        break;
      // Adicione mais casos para outros comandos, se necessário
    }
  }


    /*
     for(int vezes = 0; vezes < 50; vezes++){

      Serial.println("FORJ1MIN");
      digitalWrite(led, HIGH);
      delay(10);

      digitalWrite(led, LOW);
      delay(10);
      
     }

     for(int vezes = 0; vezes < 50; vezes++){

      Serial.println("FORJ1MAX");
      digitalWrite(led, HIGH);
      delay(10);

      digitalWrite(led, LOW);
      delay(10);
     }

          for(int vezes = 0; vezes < 50; vezes++){

      Serial.println("FORJ2MIN");
      digitalWrite(led, HIGH);
      delay(10);

      digitalWrite(led, LOW);
      delay(10);
      
     }

     for(int vezes = 0; vezes < 50; vezes++){

      Serial.println("FORJ2MAX");
      digitalWrite(led, HIGH);
      delay(10);

      digitalWrite(led, LOW);
      delay(10);
     }
      */


      /*
     while(x < 10){
      digitalWrite(led, HIGH);
      delay(200);
      digitalWrite(led, LOW);
      delay(200);

          x += 1;
     }

     */

}

void piscarLedA() {
  digitalWrite(led, HIGH);  // Liga o LED
  delay(10);  // Aguarda 500 milissegundos
  digitalWrite(led, LOW);   // Desliga o LED
}

void piscarLedB() {
  digitalWrite(led, HIGH);  // Liga o LED
  delay(3);  // Aguarda 500 milissegundos
  digitalWrite(led, LOW);   // Desliga o LED
}