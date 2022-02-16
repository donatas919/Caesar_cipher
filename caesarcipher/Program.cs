using System;

namespace cypher
{
    internal class Program
    {
        public static char Cipher(char ch, int key) 
        {
            return (char)((ch + key)  % 128);
        }
        
        public static string Encipher(string input, int key) 
        {  
            string output = string.Empty;  
  
            foreach(char ch in input)  
                output += Cipher(ch, key);  
  
            return output;  
        }  
  
        public static string Decipher(string input, int key) 
        {  
            return Encipher(input, 128 - key);  
        }
        
        public static void Main(string[] args)
        {
            int key = 3;
            string sentence;
            Console.WriteLine("Enter a sentence to encrypt:");
            sentence = Console.ReadLine();

            Console.WriteLine("Encrypted Data:");  
  
            string cipherText = Encipher(sentence, key);  
            Console.WriteLine(cipherText);
            
            Console.WriteLine("Decrypted Data:");
            
            string originalText = Decipher(cipherText, key);  
            Console.WriteLine(originalText);
        }
    }
}