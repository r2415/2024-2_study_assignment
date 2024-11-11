using System;
using System.Linq;

namespace statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] data = {
                {"StdNum", "Name", "Math", "Science", "English"},
                {"1001", "Alice", "85", "90", "78"},
                {"1002", "Bob", "92", "88", "84"},
                {"1003", "Charlie", "79", "85", "88"},
                {"1004", "David", "94", "76", "92"},
                {"1005", "Eve", "72", "95", "89"}
            };
            // You can convert string to double by
            // double.Parse(str)

            int stdCount = data.GetLength(0) - 1;
            // ---------- TODO ----------
            Console.WriteLine("Average Scores:");
            for(int i =2;i<5;i++){
                double sum = 0;
                for(int j =1;j<6;j++){
                    sum += double.Parse((data[j,i]));
                }
                Console.Write(data[0,i]+':'+' '+sum / 5);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Max and min Scores:");
            for(int i =2;i<5;i++){
                double max = double.Parse(data[2,2]);
                double min = double.Parse(data[2,2]);
                for(int j = 1;j<6;j++){
                    if (double.Parse((data[j,i]))>max) {max = double.Parse((data[j,i]));}
                    if (double.Parse((data[j,i]))<min) {min = double.Parse((data[j,i]));}
                }
                Console.Write(data[0,i]+':'+' '+'('+max+","+min+')');
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Students rank by total scores:");
            double[] array = new double[5];
            for(int i =1;i<6;i++){
                double sum = 0;
                for(int j =2;j<5;j++){
                    sum += double.Parse(data[i,j]);
                }
                array[i-1] = sum;
                
                
            }
            Array.Sort(array);
            Array.Reverse(array);
            for(int i =1;i<6;i++){
                double sum = 0;
                for(int j =2;j<5;j++){
                    sum += double.Parse(data[i,j]);
                }
                for(int k = 0;k<5;k++){
                    if (array[k] == sum){
                        if (k==0) {
                            Console.WriteLine(data[i,1]+": 1st");
                        }
                        else if (k==1) {
                            Console.WriteLine(data[i,1]+": 2nd");
                        }
                        else if (k==2) {
                            Console.WriteLine(data[i,1]+": 3rd");
                        }
                        else if (k==3) {
                            Console.WriteLine(data[i,1]+": 4th");
                        }
                        else if (k==4) {
                            Console.WriteLine(data[i,1]+": 5th");
                        }
                        
                    }
                }
                
                
            }
            // --------------------
        }
    }
}

/* example output

Average Scores: 
Math: 84.40
Science: 86.80
English: 86.20

Max and min Scores: 
Math: (94, 72)
Science: (95, 76)
English: (92, 78)

Students rank by total scores:
Alice: 4th
Bob: 1st
Charlie: 5th
David: 2nd
Eve: 3rd

*/
