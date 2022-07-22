/*

Найти расстояние между точками в пространстве 2D. Теорема Пифагора

*/
//        

double[] x = { 0, 1 };
double[] y = { 1, 0 };

double ab = x[0] - y[0];
double ac = x[1] - y[1];
var d = Math.Sqrt(ab * ab + ac * ac);
Console.WriteLine($"d = {d}");
