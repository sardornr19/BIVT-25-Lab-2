namespace Lab2
{
    public class White
    {
        const double E = 0.0001;

        public int Task1(int n)
        {
            int answer = 0;
            // code here
            for (int i = 1; i <= n; i++)
            {
                answer += 3 * i - 1;
            }
            // end
            return answer;
        }

        public double Task2(int n)
        {
            double answer = 0;
            // code here
            for (int i = 1; i <= n; i++)
            {
                answer += 1.0 / i;
            }
            // end
            return answer;
        }

        public long Task3(int n)
        {
            long answer = 1;
             // code here
            for (int i = 2; i <= n; i++)
            {
                answer *= i;
            }
            // end
            return answer;
        }

        public long Task4(int a, int b)
        {
            long answer = 1;
            // code here
            for (int i = 1; i <= b; i++)
            {
                answer *= a;
            }
            // end
            return answer;
        }

        public int Task5(int L)
        {
            int answer = 1;
            long product = 1;
            // code here
            while (product <= L)
            {
                product *= answer;
                answer += 3;
            }
            answer -= 3;
            // end
            return answer;
        }

        public double Task6(double x)
        {
            double answer = 1.0;
            double term = 1.0;
            int n = 1;
             // code here
            while (true)
            {
                term *= x * x;
                if (term < E)
                {
                    break;
                }
                else
                {
                    answer += term;
                }
                n++;
            }
            // end
            return answer;
        }

        public int Task7(int n)
        {
            int answer = 0;
            // code here
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    answer += i;
                }
                else
                {
                    answer -= i;
                }
            }
            // end
            return answer;
        }

        public int Task8(double L, double v)
        {
            int answer = 0;
            const double R = 6371.0; // радиус Земли, км
            double time = L / v;
            // code here
            if (time <= 3.0)
            {
                answer = 1;
            }
            else
            {
                answer = 0;
            }
            // end
            return answer;
        }
    }
}
