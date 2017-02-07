namespace TriangleEx
{
    public class Checker
    {
        public int TriangleChecker(string a, string b, string c)
        {
            int intA, intB, intC;
            if (int.TryParse(a, out intA) && int.TryParse(b, out intB) && int.TryParse(c, out intC))
                return Triangle(intA, intB, intC);
            return -1;
        }


        private int Triangle(int a, int b, int c)
        {
            if (SidesArePositive(a, b, c))
            {
                if (!IsTriangle(a, b, c)) return 0;
                if (IsEqilateral(a, b, c)) return 1;
                if (IsIsosceles(a, b, c)) return 2;
                return 3;
            }
            return -1;
        }

        private bool IsTriangle(int a, int b, int c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        private bool IsIsosceles(int a, int b, int c)
        {
            return (a == b) || (a == c) || (b == c);
        }

        public bool IsEqilateral(int a, int b, int c)
        {
            return (a == b) && (b == c);
        }

        private bool SidesArePositive(int a, int b, int c)
        {
            return (a > 0) && (b > 0) && (c > 0);
        }
    }
}