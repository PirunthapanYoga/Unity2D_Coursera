namespace Exercise6
{
    /// <summary>
    /// Programe Enercise 6 Trigonometry with float
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Find Sin and Cosin of a degree from user input 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Enter the angle in degrees : ");
            float angleDegree =float.Parse(Console.ReadLine());
            Console.WriteLine(angleDegree);

            float cosine = MathF.Cos(angleDegree*MathF.PI/180);
            Console.WriteLine("Cosine of {0} Degree is {1}" , angleDegree , cosine);

            float sin = MathF.Sin(angleDegree * MathF.PI / 180);
            Console.WriteLine("Sin of {0} Degree is {1} " , angleDegree , sin);

            Console.WriteLine(Math.Pow(sin , 2) + Math.Pow(cosine , 2));
        }
    }
}