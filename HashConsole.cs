using System;  
using System.Text;  
using System.Security.Cryptography;  
  
namespace HashConsole  
{  
    public class Program  
    {  
        public static void Main(string[] args)  
        {   
            Console.Write("Enter a string .: ");
			string plain_STR = plain_STR = Console.ReadLine();
			Console.WriteLine();
            Console.WriteLine("Raw data .: {0}", plain_STR);  
            string hashed_STR = ComputeSha256Hash(plain_STR);  
            Console.WriteLine("Hash 256 .: {0}", hashed_STR);  
            //Console.WriteLine(ComputeSha256Hash(plain_STR));  
            Console.ReadLine();  
        }  
  
        static string ComputeSha256Hash(string rawData)  
        {    
            using (SHA256 sha256Hash = SHA256.Create())  
            {   
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));  
                StringBuilder builder = new StringBuilder();  
                for (int i = 0; i < bytes.Length; i++)  
                    builder.Append(bytes[i].ToString("x2"));  
                return builder.ToString();  
            }  
        }         
    }  
}