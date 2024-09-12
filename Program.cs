using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia(numero: "(34)98888-6655", modelo: "xz-55", imei:"123456789", memoria: 4);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Calculadora");
nokia.InstalarAplicativo("Sonic");
nokia.Numero = "(34)98877-6666";
nokia.ImprimirInformacoesTelefone();

Iphone iphone = new Iphone(numero: "(34)56877-6577", modelo: "I-25", imei:"729459700", memoria: 4);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
iphone.InstalarAplicativo("Speak-AI");
iphone.InstalarAplicativo("MS-Office-360");
iphone.ImprimirInformacoesTelefone();