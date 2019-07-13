# LibraryCalc05
Biblioteca de operações matemáticas avançadas

[![Build status](https://ci.appveyor.com/api/projects/status/yqf9lppp23y2ivq4/branch/master?svg=true)](https://ci.appveyor.com/project/mateusggeracino/librarycalc05/branch/master)

## How to install
Install-Package LibraryCalc05 -Version 1.0.2

![Nuget](https://img.shields.io/nuget/dt/LibraryCalc05.svg)

```cs
  class Program{
    var calc = new Calc();
    var valores = new Valores();
    valores.AdicionarValorA(10);
    valores.AdicionarValorB(20);
    
    var resultado = calc.Somar(valores);
  }
  ```
