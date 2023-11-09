using System;

namespace Array1
{
    class Program{
        // int p,r;
        // int[,] a;
        // int[] b;
        // Program(int x, int y)
        // {
        //     p=x;
        //     r=y;
        //     a=new int[p,r];
        //     b=new int[p*r];
        // }
    // public void readmatrix(){
        //length of array
        // int[] arrayA = new int[10];
        // int lengthA = arrayA.Length;
        // Console.WriteLine("Length of ArrayA : {0}",+lengthA);
        // long longLength = arrayA.LongLength;
        // Console.WriteLine("Length of Long Length ArrayA : {0}",+longLength);
        // int[,] twoD = new int[20,50];
        // Console.WriteLine("Size of the 2D Array : {0}",+twoD.Length);
        // Console.ReadLine();

        //convert 2D to 1D
    //     for(int i=0;i<p;i++)
    //     {
    //         for(int j=0;j<r;j++)
    //         {
    //             Console.Write("a[{0},{1}]=",i,j);
    //             a[i,j] = Convert.ToInt32(Console.ReadLine());
    //         }
    //     }
    // }
    // public void printtwodimensionalarray()
    // {
    //     for(int i=0;i<p;i++)
    //     {
    //         for(int j=0;j<r;j++)
    //         {
    //             Console.Write("{0}\t",a[i,j]);
    //         }
    //         Console.Write("\n");
    //     }
    // }
    // public void convert()
    // {
    //     int k=0;
    //     for(int i=0;i<p;i++)
    //     {
    //         for(int j=0;j<r;j++)
    //         {
    //             b[k++]=a[i,j];
    //         }
    //     }
    // }
    // public void printonedimensionalarray()
    // {
    //     for(int i=0;i<p*r;i++)
    //     {
    //         Console.WriteLine("{0}\t",b[i]);
    //     }
    // }

    static void Main()
    {
        // Program obj = new Program(2,3);
        // Console.WriteLine("Enter the Elements:");
        // obj.readmatrix();
        // Console.WriteLine("\nGiven 2-D Array() is:");
        // obj.printtwodimensionalarray();
        // obj.convert();
        // Console.WriteLine("\nConverted 1-D Array is :");
        // obj.printonedimensionalarray();
        // Console.ReadLine();

        //jagged arrays
        // int[][] jagArray = new int[3][];
        // jagArray[0] = new int[2];
        // jagArray[0][0] = 12;
        // jagArray[0][1] = 13;
        // jagArray[1] = new int[1] {12};
        // jagArray[2] = new int[3] {15,16,17};
        // for(int i=0;i<jagArray.Length;i++)
        // {
        //     int[] innerArray = jagArray[i];
        //     for(int a=0;a<innerArray.Length;a++)
        //     {
        //         Console.WriteLine(innerArray[a]+" ");
        //     }
        // }

        //min and max
        // int[] Arr = {20,-10,-30,0,5,10,30};
        // Console.WriteLine("Maximun Elememt:"+Arr.Max());
        // Console.WriteLine("Minimum Element:"+Arr.Min());

        //count negative values
        // int[] arr = new int[100];
        // int i,num;

        // Console.WriteLine("Enter size of array:");
        // num = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine("Enter elements in array:");
        // for(i=0;i<num;i++)
        // {
        //     arr[i] = Convert.ToInt32(Console.ReadLine());
        // }
        // Console.WriteLine("All negative elements are:");
        // for(i=0;i<num;i++)
        // {
        //     if(arr[i]<0)
        //     {
        //         Console.WriteLine(arr[i]);
        //     }
        // }

        //sum of elements
        // int[] arr = new int[100];
        // int i, num, sum = 0;
        // Console.WriteLine("Enter size of the array: ");
        // num = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter "+num+" elements in the array: ");  
        // for(i=0; i<num; i++)
        // {
        //     arr[i] = Convert.ToInt32(Console.ReadLine());            
        // }
        // for(i=0; i<num; i++)
        // {
        //     sum = sum + arr[i]; // Calculating sum
        // }
        // Console.WriteLine("Sum of all elements of array: "+sum);

        //odd or even
        // int[] arr = new int[100];
        // int i, num, evennum, oddnum;
        // Console.WriteLine("Enter size of the array: ");
        // num = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter "+num+" elements in the array: ");  
        // for(i=0; i<num; i++)
        // {
        //     arr[i] = Convert.ToInt32(Console.ReadLine());            
        // }
        // evennum = 0; // Assuming 0 even numbers
        // oddnum = 0; // Assuming 0 odd numbers
        // for (i = 0; i < num; i++)
        // {
        //     if (arr[i] % 2 == 0)
        //     {
        //         evennum++;
        //     }
        //     else
        //     {
        //         oddnum++; // increment oddnumber count
        //     }
        // }
        // Console.WriteLine("Total even  numbers: "+evennum);
        // Console.WriteLine("Total odd numbers: " + oddnum);

        //insert element
        // int[] arr = new int[100];
        // int i, num, size, position;
        // Console.WriteLine("Enter size of the array: ");
        // size = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter elements in the array: ");              
        // for(i=0; i<size; i++)
        // {
        //     arr[i] = Convert.ToInt32(Console.ReadLine());            
        // }
        // Console.WriteLine("Enter element to insert: ");
        // num = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Enter the element position: ");
        // position = Convert.ToInt32(Console.ReadLine());
        // if (position > size + 1 || position <= 0)
        // {
        //     Console.WriteLine("Invalid position! Please enter position between 1 to " + num);
        // }
        // else
        // {
        //     for (i = size; i >= position; i--)
        //     {
        //         arr[i] = arr[i - 1];
        //     }
        //     arr[position - 1] = num;
        //     size++;
        //     Console.WriteLine("Array elements after insertion :");
        //     for (i = 0; i < size; i++)
        //     {
        //         Console.WriteLine(arr[i] + "\t");                
        //     }
        // }

        //print unique element
        // int[] arr = new int[100];;
        // int i, j, k, size, isUnique;
        // Console.WriteLine("Enter size of the array: ");
        // size = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter elements in the array: ");              
        // for(i=0; i<size; i++)
        // {
        //     arr[i] = Convert.ToInt32(Console.ReadLine());            
        // }
        //  for(i=0; i<size; i++)
        // {
        //     isUnique = 1;
        //     for(j=i+1; j<size; j++)
        //     {
        //         if(arr[i]==arr[j])
        //         {
        //             for(k=j; k<size-1; k++)
        //             {
        //                 arr[k] = arr[k+1];
        //             }
        //             size--;
        //             j--;
        //             isUnique = 0;
        //         }
        //    }
        //     if (isUnique != 1)
        //     {
        //         for (j = i; j < size - 1; j++)
        //         {
        //             arr[j] = arr[j + 1];
        //         }
        //         size--;
        //         i--;
        //     }
        // }
        //  Console.WriteLine("All unique elements in the array are: ");
        //  for (i = 0; i < size; i++)
        //  {
        //      Console.WriteLine(arr[i] + "\t");
        //  }

        //sort array
        // int[] arr = new int[100];;
        // int size, i, j, temp;
        // Console.WriteLine("Enter size of the array: ");
        // size = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter elements in the array: ");              
        // for(i=0; i<size; i++)
        // {
        //     arr[i] = Convert.ToInt32(Console.ReadLine());            
        // }
        // for (i = 0; i < size; i++)
        // {
        //     for (j = i + 1; j < size; j++)
        //     {
        //         if (arr[j] < arr[i])
        //         {
        //             temp = arr[i];
        //             arr[i] = arr[j];
        //             arr[j] = temp;
        //         }
        //     }
        // }
        // Console.WriteLine("Elements of array in sorted ascending order:");
        // for (i = 0; i < size; i++)
        // {
        //     Console.WriteLine(arr[i]);
        // }

        //copy elements to another array
        // int[] arr = new int[100];
        // int[] first = new int[100];
        // int[] second = new int[100];
        // int i, num;
        // Console.WriteLine("Enter size of the array: ");
        // num = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter elements in the array: ");
        // for (i = 0; i < num; i++)
        // {
        //     first[i] = Convert.ToInt32(Console.ReadLine());            
        // }
        // for (i = 0; i < num; i++)
        // {
        //     second[i] = first[i];
        // }
        // Console.WriteLine("Elements of first array are:");
        // for (i = 0; i < num; i++)
        // {
        //     Console.Write(first[i]+"\t");            
        // }
        // Console.WriteLine("\nElements of second array are:");        
        // for (i = 0; i < num; i++)
        // {
        //    Console.Write(second[i]+ "\t");
        // }

        //count no. of each element
        // int i, j, count, num;
        // int[] arr = new int[100];
        // int[] frequency = new int[100];
        // Console.WriteLine("Enter size of the array: ");
        // num = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter elements in the array: ");
        // for (i = 0; i < num; i++)
        // {
        //     arr[i] = Convert.ToInt32(Console.ReadLine());
        //     frequency[i] = -1;
        // }
        // for (i = 0; i < num; i++)
        // {
        //     count = 1;
        //     for (j = i + 1; j < num; j++)
        //     {
        //         if (arr[i] == arr[j])
        //         {
        //             count++;
        //             frequency[j] = 0;
        //         }
        //     }
        //     if (frequency[i] != 0)
        //     {
        //         frequency[i] = count;
        //     }
        // }
        // Console.WriteLine("\nFrequency of all elements of array : \n");
        // for (i = 0; i < num; i++)
        // {
        //     if (frequency[i] != 0)
        //     {
        //         Console.WriteLine(arr[i] + " occurs " + frequency[i]+ " times");                
        //     }
        // }

        //delete duplicate elements
        // int[] arr = new int[100];
        // int num; // Total number of elements in array
        // int i, j, k;
        // Console.WriteLine("Enter size of the array: ");
        // num = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter elements in the array: ");
        // for (i = 0; i < num; i++)
        // {
        //     arr[i] = Convert.ToInt32(Console.ReadLine());           
        // }
        // for (i = 0; i < num; i++)
        // {
        //     for (j = i + 1; j < num; j++)
        //     {
        //         if (arr[i] == arr[j])
        //         {
        //             for (k = j; k < num; k++)
        //             {
        //                 arr[k] = arr[k + 1];
        //             }
        //             num--;
        //             j--;
        //         }
        //     }
        // }
        // Console.WriteLine("\nArray elements after deleting duplicates : ");
        // for (i = 0; i < num; i++)
        // {
        //     Console.WriteLine(arr[i]);
        // }        

        //count total duplicates
        // int[] arr = new int[100];
        // int i, j, num, count = 0;
        // Console.WriteLine("Enter size of the array: ");
        // num = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter elements in the array: ");
        // for (i = 0; i < num; i++)
        // {
        //     arr[i] = Convert.ToInt32(Console.ReadLine());           
        // }
        // for (i = 0; i < num; i++)
        // {
        //     for (j = i + 1; j < num; j++)
        //     {
        //         if (arr[i] == arr[j])
        //         {
        //             count++;
        //             break;
        //         }
        //     }
        // }
        // Console.WriteLine("\n Total number of duplicate elements found in array:"+count);

        //reverse array
        int[] array = new int[100];
        int size, i;      
        Console.WriteLine("Enter size of the array: ");
        size = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter elements in array: ");
        for (i = 0; i < size; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());           
        }
        Console.WriteLine("\nArray in reverse order: ");
        for (i = size - 1; i >= 0; i--)
        {
            Console.Write("\t"+ array[i]);
        } 
        Console.Read();
    }
}
}