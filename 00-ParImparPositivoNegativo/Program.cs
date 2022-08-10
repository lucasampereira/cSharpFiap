// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

/*
int numeroDeVezes = 5;
for(int i = 0; i < numeroDeVezes; i++) {
    Console.WriteLine("Bem-vindo ao curso de .Net! " + i);
}
*/

int numero = 2;

if(numero < 0) {
    Console.WriteLine("O número " + numero + " é negativo");
} else if(numero == 0) {
    Console.WriteLine("O número " + numero + " é nulo");
} else {
    Console.WriteLine("O número " + numero + " é positivo");
}

if(numero == 0) {
    Console.WriteLine("Zero não é par nem ímpar");
} else if(numero % 2 == 0) {
    Console.WriteLine("O número " + numero + " é par");
} else {
    Console.WriteLine("O número " + numero + " é ímpar");
}
