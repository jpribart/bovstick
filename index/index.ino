// Marcos Lima - Vanderlan - Marcos Berg - Jarson
#include <SPI.h>
#include <MFRC522.h>
#include <SD.h>

File myFile;
 
RTCDateTime dataehora; 

#define SS_PIN 10
#define RST_PIN 9

MFRC522 mfrc522(SS_PIN, RST_PIN); 
// Acesso ao metodo do RFID ultilizando Paramentros de Entradas(Porta 9,10)

// Leds indicadores acesso liberado ou negado

int led_liberado = 5;

int led_negado = 6;

char st[20];

String txt = "lista_tag_"+dataehora.year+"-"+dataehora.day+".txt";

void setup() 
{
  pinMode(led_liberado, OUTPUT);
  pinMode(led_negado, OUTPUT);

  Serial.begin(9600);
  // Inicia  SPI bus
  SPI.begin();
  // Inicia MFRC522
  mfrc522.PCD_Init(); 
  // Mensagens iniciais no serial monitor
  Serial.println("Aproxime o seu cartao do leitor...");
  Serial.println();
}

void loop() 
{
  // Aguarda a aproximacao do cartao
  if ( ! mfrc522.PICC_IsNewCardPresent()) 
  {
    return;
  }
  // Seleciona um dos cartoes
  if ( ! mfrc522.PICC_ReadCardSerial()) 
  {
    return;
  }
  // Mostra UID na serial
  Serial.print("Tag :");
  String conteudo= "";
  byte letra;
  for (byte i = 0; i < mfrc522.uid.size; i++) 
  {

     Serial.print(mfrc522.uid.uidByte[i] < 0x10 ? " 0" : " ");
     Serial.print(mfrc522.uid.uidByte[i], HEX);
     conteudo.concat(String(mfrc522.uid.uidByte[i] < 0x10 ? " 0" : " "));
     conteudo.concat(String(mfrc522.uid.uidByte[i], HEX));
  }
  Serial.println();
  Serial.print("Mensagem : ");
  conteudo.toUpperCase();
  Serial.println(conteudo);


  if(GravarTag(conteudo)){
    Serial.println("<200-OK> Tag Salva Com Sucesso");
  }else{
   Serial.println("Erro ao salvar a Tag");
  }


  delay(5);
}



bool GravarTag(tag){
  if(VerificaTagExistente(tag)){

      GravarArquivo(tag);
  }
}


bool VerificaTagExistente(tag){
   if (tag.length > 0)
   {
      Serial.print("tag OK...")
    return true;

   }else{
    Serial.print("tag inexistente...")
    return false;
   }
}


String[] txtAll;
int x =0;
// Passar tag ja validada.
bool GravarArquivo(tag){

  if (!SD.begin(4)) {
    Serial.println("Falha na Inicialização!");
    return false;
  }
  Serial.println("Inicialização Passed.");
  
  arquivo = SD.open(txt, FILE_WRITE);
   
   
   if(SD.exists(txt)){
     arquivo= SD.open(txt);
   
      while(arquivo.read()){
         txtAll[x] = arquivo[x];
         x++;
      }
    
    
    for (int i = 0; i < txtAll.length; ++i)
    {
        arquivo.println(txtAll[0]);
    }
   
     arquivo.close();
     Serial.println("arquivo gravado com sucesso ");

     return true;
   }else{
    Serial.println("Erro na gravacao...");
    return false ;
   }
}


bool TagExistenteTxt(int tag,int tamanho){
 for(int x=0; x<= tamanho;x++ ){
     if(tag[x]== )
 }
}




