using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using _321labs.Reflection;
namespace _321labs
{
    class Program
    {

        static void Main()
        {
            foreach (var item in typeof(Student).GetMembers())
            {
                Console.WriteLine($"{item.MemberType} {item.Name} ");

                // If the member is a method, display information about its parameters.

                if (item.MemberType is MemberTypes.Method)
                {
                    var me = (MethodInfo)item;
                    Console.WriteLine($"{"",5}Модификаторы: \n{"",10}Абстрактный: {me.IsAbstract} \n{"",10}Публичный: {me.IsPublic} \n{"",10}Статичный: {me.IsStatic}");
                    Console.WriteLine($"{"",5}Возвращаемый тип: {me.ReturnType}");
                    if (me.GetParameters().Length == 0) continue;
                    Console.WriteLine($"{"",5}Параметры:") ;
                    foreach (ParameterInfo pi in me.GetParameters())
                    {
                        Console.WriteLine($"{"",10} Тип={pi.ParameterType}, Имя={pi.Name}");
                    }
                }

                // If the member is a property, display information about the property's accessor methods.
                if (item.MemberType is MemberTypes.Property)
                {
                    var prop = (PropertyInfo)item;
                    Console.WriteLine($"{"",5} Методы доступа:");
                    foreach (MethodInfo am in prop.GetAccessors())
                    {
                        Console.WriteLine($"{"",10}{am.ReturnType} {am.Name}");
                        Console.WriteLine($"{"",10}Модификаторы: \n{"",13}Абстрактный: {am.IsAbstract} \n{"",13}Публичный: {am.IsPublic} \n{"",13}Статичный: {am.IsStatic}");
                        
                    }
                }

                if (item.MemberType is MemberTypes.Constructor)
                {
                    var cons = (ConstructorInfo)item;
                    Console.WriteLine($"{"",5}Модификаторы: \n{"",10}Абстрактный: {cons.IsAbstract} \n{"",10}Публичный: {cons.IsPublic} \n{"",10}Статичный: {cons.IsStatic}");

                    if (cons.GetParameters().Length == 0) continue;
                    Console.WriteLine($"{"",5} Параметры:");
                    foreach (ParameterInfo pi in cons.GetParameters())
                    {
                        Console.WriteLine($"{"",10} Тип={pi.ParameterType}, Имя={pi.Name}");
                    }
                }
            }

        }
    }
}
