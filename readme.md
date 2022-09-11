# Práctico de Números Enteros

- 🧑🏻‍💻 Materia: Programación 1
- 🚀 Lenguage: C#
- 💅 Docente: Ing. Mollo
- ⚡️ Facultad: [FICCT](https://www.facebook.com/FICCTUAGRMOFICIAL)
- 📦 Paradigma: Programación orientada a objetos
- 🧑🏻‍💻 Desarrollador: [@sauterdev](https://github.com/LuiSauter)

## Contenido del Práctico
Desarrollar el practico de la clase **Numero Entero** con las siguientes operaciones
en **C#**:
1. [Cargar](#1-cargar)
2. [Descargar](#2-descargar)
3. [Verificar si es par](#3-verificar-si-es-par)
4. [Verificar si un numero entero es múltiplo de otro número entero](#4-verificar-si-un-numero-entero-es-múltiplo-de-otro-número-entero)
5. [Verificar si un numero entero es sub múltiplo de otro número entero](#5-verificar-si-un-numero-entero-es-sub-múltiplo-de-otro-número-entero)
6. [Verificar si es primo](#6-verificar-si-es-primo)
7. [Verificar si es capicúa](#7-verificar-si-es-capicúa)
8. [Verificar si es de la serie de Fibonacci](#8-verificar-si-es-de-la-serie-de-fibonacci)
9. [Obtener el factorial de un numero entero](#9-obtener-el-factorial-de-un-numero-entero)
10. [Verificar si los dígitos de un numero entero están ordenados](#10-verificar-si-los-dígitos-de-un-numero-entero-están-ordenados)

**Primeros pasos**
Crear la clase [IntegerNumber.cs](https://github.com/codeficct/numeros-enteros-poo/blob/main/IntegerNumber.cs) o NúmeroEntero.cs:
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NumeroEntero_poo
{
    class IntegerNumber
    {
        // Properties
        private int number;
        // Constructor
        public IntegerNumber()
        {
            number = 0;
        }
        // Methods - code here
    }
}
```
## 1. Cargar

<details>
  <summary>Ver código</summary>

```csharp
namespace NumeroEntero_poo
{
    class IntegerNumber
    {
        // Properties
        private int number;
        // Constructor
        public IntegerNumber()
        {
            number = 0;
        }
        // Methods - Cargar
        public void setNumber(int value)
        {
            number = value;
        }
    }
}
```

</details>

## 2. Descargar

<details>
  <summary>Ver código</summary>

```csharp
namespace NumeroEntero_poo
{
    class IntegerNumber
    {
        // Properties
        private int number;
        // Constructor
        public IntegerNumber()
        {
            number = 0;
        }
        // Methods - Descargar
        public int getNumber()
        {
            return number;
        }
    }
}
```

</details>

## 3. Verificar si es par

<details>
  <summary>Ver código</summary>

```csharp
namespace NumeroEntero_poo
{
    class IntegerNumber
    {
        // Properties
        private int number;
        // Constructor
        public IntegerNumber()
        {
            number = 0;
        }
        // Methods - Verificar si es Par
        public bool isEven()
        {
            return number % 2 == 0;
        }
    }
}
```

</details>

## 4. Verificar si un numero entero es múltiplo de otro número entero

<details>
  <summary>Ver código</summary>

```csharp
namespace NumeroEntero_poo
{
    class IntegerNumber
    {
        // Properties
        private int number;
        // Constructor
        public IntegerNumber()
        {
            number = 0;
        }
        // Methods - Verificar si es multiplo de otro numero entero
        public bool isMultiple(int multiple)
        {
            return number % multiple == 0;
        }
    }
}
```

</details>

## 5. Verificar si un numero entero es sub múltiplo de otro número entero

<details>
  <summary>Ver código</summary>

```csharp
namespace NumeroEntero_poo
{
    class IntegerNumber
    {
        // Properties
        private int number;
        // Constructor
        public IntegerNumber()
        {
            number = 0;
        }
        // Methods - Verificar si es sub-multiplo de otro numero entero
        public bool isMultiple(int multiple)
        {
            return number % multiple == 0;
        }

        public bool isSubMultiple()
        {
            int index = 0;
            bool result = false;
            for (index = 1; index <= number; index++)
                if (isMultiple(index)) result = true;
            return result;
        }
    }
}
```

</details>

## 6. Verificar si es primo

<details>
  <summary>Ver código</summary>

```csharp
namespace NumeroEntero_poo
{
    class IntegerNumber
    {
        // Properties
        private int number;
        // Constructor
        public IntegerNumber()
        {
            number = 0;
        }
        // Methods - Verificar si es Primo
        public bool isPrime()
        {
            int index;
            double half = Math.Sqrt(number);
            for (index = 2; index <= half; index++)
            {
                if (number % index == 0) return false;
            }
            return number > 1;
        }
    }
}
```

</details>

## 7. Verificar si es capicúa

<details>
  <summary>Ver código</summary>

```csharp
namespace NumeroEntero_poo
{
    class IntegerNumber
    {
        // Properties
        private int number;
        // Constructor
        public IntegerNumber()
        {
            number = 0;
        }
        // Methods - Verificar si es capicúa o palindromo
         public int reverseInteger()
        {
            int num, digit, result = 0;
            num = number;
            while (num > 0)
            {
                digit = num % 10;
                result = (result * 10) + digit;
                num = num / 10;
            }
            return result;
        }

        public bool isPalindrome()
        {
            return reverseInteger() == number;
        }
    }
}
```

</details>

## 8. Verificar si es de la serie de Fibonacci

<details>
  <summary>Ver código</summary>

```csharp
namespace NumeroEntero_poo
{
    class IntegerNumber
    {
        // Properties
        private int number;
        // Constructor
        public IntegerNumber()
        {
            number = 0;
        }
        // Methods - Verificar si pertenece a Fibonacci
        public bool checkIfIsFibonacci(int a = 0, int b = 1)
        {
            if (number == 0 || number == 1) return true;
            int c = a + b;
            if (c == number) return true;
            else if (c > number) return false;
            return checkIfIsFibonacci(b, c);
        }
    }
}
```

</details>

## 9. Obtener el factorial de un numero entero

<details>
  <summary>Ver código</summary>

```csharp
namespace NumeroEntero_poo
{
    class IntegerNumber
    {
        // Properties
        private int number;
        // Constructor
        public IntegerNumber()
        {
            number = 0;
        }
        // Methods - Obtener el factorial
        public double getFactorial()
        {
            double result = 1;
            int index;
            if (number != 0)
            {
                for (index = Math.Abs(number); index > 1; index--)
                {
                    result = result * index;
                }
                if (number < 0) result = -result;
            }
            return result;
        }
    }
}
```

</details>

## 10. Verificar si los dígitos de un numero entero están ordenados

<details>
  <summary>Ver código</summary>

```csharp
namespace NumeroEntero_poo
{
    class IntegerNumber
    {
        // Properties
        private int number;
        // Constructor
        public IntegerNumber()
        {
            number = 0;
        }
        // Methods - Verificar si los digitos
        // de un número entero estan ordenados
        public bool isOrder()
        {
            int[] numArray = new int[number];
            int digit, clone = number, index = 1, numOrder = 0;
            while (clone > 0)
            {
                digit = clone % 10;
                numArray[index] = digit;
                clone = clone / 10;
                index++;
            }
            Array.Sort(numArray);
            foreach(int value in numArray)
            {
                numOrder = numOrder * 10 + value;
            }
            return number == numOrder;
        }
    }
}
```

</details>
