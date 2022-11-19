# Obliczanie pierwiastka metodą Herona

Napisz metodę wyznaczającą pierwiastek kwadratowy $\sqrt{a}$ liczby rzeczywistej za pomocą algorytmu Herona.
W przypadku niepoprawnego argumentu $a<0$ metoda rzuca wyjątek ''ArgumentException'' z odpowiednim komunikatem. 

Napisz program, który wczyta z konsoli liczbę i wyznaczy jej pierwiastek kwadratowy. 
Obsłuż wszystkie sytuacje wyjątkowe (niepoprawny format liczby, zły argument metody pierwiastkującej).

Przybliżenie pierwiastka liczby $a$ wyznaczamy wzorem iteracyjnym

$$x_{i+1} =\frac{1}{2} \left( x_i + \frac{a}{x_i}\right)$$

Algorytm:
1. ustaw wartości początkowe $x_0=1, i=0, \epsilon=0.0000001$
2. oblicz $x_{i+1}$ 
3. jeśli $|x_{i+1} - x_i | < \epsilon$ to zwróć pierwiastek równy $x_{i+1}$
4. zwiększ $i=i+1$ i wróć do pkt. 2

