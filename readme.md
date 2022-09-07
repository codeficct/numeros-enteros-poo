# Práctico de Números Enteros

- 🧑🏻‍💻 Materia: Programación 1
- 🚀 Lenguage: C#
- 💅 Docente: Ing. Mollo
- 🎓 Universidad: [UAGRM](https://www.uagrm.edu.bo/)
- ⚡️ facultad: [FICCT](https://www.facebook.com/FICCTUAGRMOFICIAL)

## Contenido del Práctico
Desarrollar el practico de la clase **Numero Entero** con las siguientes operaciones
en **C#**:
1. [Cargar](#cargar)
2. [Descargar](#descargar)
3. [Verificar si es par](#verificar-si-es-par)
4. [Verificar si un numero entero es múltiplo de otro número entero](#verificar-si-un-numero-entero-es-múltiplo-de-otro-número-entero)
5. [Verificar si un numero entero es sub múltiplo de otro número entero](#verificar-si-un-numero-entero-es-sub-múltiplo-de-otro-número-entero)
6. [Verificar si es primo](#verificar-si-es-primo)
7. [Verificar si es capicúa](#verificar-si-es-capicúa)
8. [Verificar si es de la serie de Fibonacci](#verificar-si-es-de-la-serie-de-fibonacci)
9. [Obtener el factorial de un numero entero](#obtener-el-factorial-de-un-numero-entero)
10. [Verificar si los dígitos de un numero entero están ordenados](#verificar-si-los-dígitos-de-un-numero-entero-están-ordenados)

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
## Cargar

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

## Descargar

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

## Verificar si es par

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

## Verificar si un numero entero es múltiplo de otro número entero

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

## Verificar si un numero entero es sub múltiplo de otro número entero

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
            for (index = 1; index < number; index++)
            {
                if (isMultiple(index))
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
```

</details>

## Verificar si es primo

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
            bool result = false;
            int r;
            if (number > 1)
            {
                int index = 1;
                do
                {
                    index++;
                    r = number % index;
                } while (r != 0);
                result = (number == 1);
            }
            return result;
        }
    }
}
```

</details>

## Verificar si es capicúa

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
            int num, digit, result;
            result = 0;
            num = number;
            digit = num % 10;
            result = (result * 10) + digit;
            num = num / 10;
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

## Verificar si es de la serie de Fibonacci

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
        public bool checkIfIsFibonacci()
        {
            int a = 0, b = 0, c, index;
            bool result = false;

            for (index = 0; index <= number; index++)
            {
                c = a + b;
                if (c == number) result = true;
                a = b; b = c;
            }

            return result;
        }
    }
}
```

</details>

## Obtener el factorial de un numero entero

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

## Verificar si los dígitos de un numero entero están ordenados

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
            int numOrder = 0;
            int[] numArray = new int[number.ToString().Length];
            int digit, index, clone = number;
            for (index = 0; index < number; index++)
            {
                digit = clone % 10;
                numArray[index] = digit;
                clone = clone / 10;
            }

            Array.Sort(numArray);

            for (int i = 0; i < numArray.Length; i++)
            {
                numOrder = numOrder * 10 + numArray[index];
            }
            return number == numOrder;
        }
    }
}
```

</details>
