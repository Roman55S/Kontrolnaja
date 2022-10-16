string [] arrayFirst = {"123", "Mom" , "2022" , "sister" , "646", "rum" }; 
int size = 0;

for (int i = 0; i < arrayFirst.Length; i++)
{  
    if (arrayFirst[i].Length <= 3)
    {
        size++;
    }  
}
string [] arraySecond = new string [size];
int k = 0;
for (int j = 0; j <arrayFirst.Length; j++)
{
    
   if (arrayFirst[j].Length <= 3) 
   {
       
        arraySecond[k] = arrayFirst[j];
        k++;

   }
}
Console.WriteLine(String.Join(", ",arraySecond));

//Решение с использованием метода.

// int SearchLenghtForNewArray (string [] array)
// {
//     int size = 0;
//     for (int i = 0; i < arrayFirst.Length; i++)
//     {  
//      if (arrayFirst[i].Length <= 3)
//      {
//          size++;
//      }  
//     }
//     return size;
// }

// string [] arraySecond = new string[SearchLenghtForNewArray(arrayFirst)];
// int k = 0;
// for (int j = 0; j <arrayFirst.Length; j++)
// {
//    if (arrayFirst[j].Length <= 3) 
//     {
        
//       arraySecond[k] = arrayFirst[j];
//       k++;

//     }
// }
// Console.WriteLine(String.Join(", ",arraySecond));