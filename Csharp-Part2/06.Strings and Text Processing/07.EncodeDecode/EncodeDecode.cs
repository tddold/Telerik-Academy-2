using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 7. Encode/decode
//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over 
//the first letter of the string with the first of the key, the second – with the second, etc. 
//When the last key character is reached, the next is the first.


class EncodeDecode
{
    static void Main()
    {
        Console.WriteLine("Enter original text");
        string originalText = Console.ReadLine();
        Console.WriteLine("Enter cipher:");
        string cipher = Console.ReadLine();
        
        char[] originalTextChars = originalText.ToCharArray();
        char[] cipherChars = cipher.ToCharArray();
        char[] encodedMessageChars = new char[originalText.Length];
        StringBuilder decodedMessageBuilder = coding(originalTextChars, cipherChars);       
        Console.WriteLine("Decoded message:");
        Console.WriteLine(decodedMessageBuilder.ToString());
        StringBuilder encodedMessageBuilder = coding(decodedMessageBuilder.ToString().ToCharArray(), cipherChars);
        Console.WriteLine("Encoded message:");
        Console.WriteLine(encodedMessageBuilder.ToString());       
      

    }
    public static StringBuilder coding(char[] code, char[] cipher)
    {
        StringBuilder messageBuilder = new StringBuilder();
        int rotationCount=0;
        for (int i = 0; i < code.Length; i++)
        {
            int result = (code[i] - 65) ^ (cipher[i - rotationCount * cipher.Length] - 65);
            messageBuilder.Append((char)(result + 65));
            if (i == cipher.Length - 1)
            {
                rotationCount++;
            }
        }
        return messageBuilder;
    }
}

