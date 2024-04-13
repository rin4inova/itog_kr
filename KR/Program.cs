
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string [] LessThreeElements(string [] arr) {
    string [] newArray = new string [arr.Length];
    int count = 0;
    for (int i = 0; i < arr.Length; i++ ){
        if(arr[i].Length <=3) {
        newArray[count] = arr[i];      
        count++;
    }
    }
    return newArray;   
}

void PrintArray(string[]arr){
    for (int i = 0; i< arr.Length;i++ ){
        Console.Write(arr[i]+" ");
    }
}


string [] array = {"Ru", "b12", "Kazan", "dsf", "df"};

PrintArray(LessThreeElements(array));