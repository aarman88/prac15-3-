using System;

class Program
{
    static void Main()
    {
        Type myClassType = typeof(MyClass);

        // Создание экземпляра MyClass без прямого вызова конструктора
        object myClassInstance = Activator.CreateInstance(myClassType);

        // Изменение значений свойств
        myClassType.GetProperty("PublicProperty").SetValue(myClassInstance, 42);

        // Вызов метода
        myClassType.GetMethod("PublicMethod").Invoke(myClassInstance, null);

        // Печать значения свойства для проверки изменений
        Console.WriteLine($"PublicProperty после изменения: {myClassType.GetProperty("PublicProperty").GetValue(myClassInstance)}");
    }
}
