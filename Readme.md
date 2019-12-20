``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-4710HQ CPU 2.50GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.100
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT
  DefaultJob : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT


```
|                              Method |      Mean |     Error |    StdDev |    Median | Ratio | Rank |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------ |----------:|----------:|----------:|----------:|------:|-----:|-------:|------:|------:|----------:|
| GetYearFromSpanWithManualConversion |  12.91 ns |  0.118 ns |  0.105 ns |  12.87 ns |  0.01 |    1 |      - |     - |     - |         - |
|                     GetYearFromSpan |  38.59 ns |  0.274 ns |  0.243 ns |  38.50 ns |  0.04 |    2 |      - |     - |     - |         - |
|                GetYearFromSubstring |  70.67 ns |  3.892 ns | 11.477 ns |  75.72 ns |  0.05 |    3 | 0.0102 |     - |     - |      32 B |
|                    GetYearFromSplit | 156.39 ns |  2.280 ns |  1.904 ns | 155.69 ns |  0.17 |    4 | 0.0508 |     - |     - |     160 B |
|                 GetYearFromDateTime | 940.49 ns | 17.561 ns | 17.248 ns | 940.22 ns |  1.00 |    5 |      - |     - |     - |         - |
