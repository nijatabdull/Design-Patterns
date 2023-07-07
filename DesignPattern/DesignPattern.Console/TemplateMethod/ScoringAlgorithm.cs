namespace DesignPattern.Console.TemplateMethod
{
    public abstract class ScoringAlgorithm
    {
        public int Point { get;  set; }
        public int Degree { get;  set; }

        public int Count()
        {
            int totalPoint = GetTotalPoint(Point);

            int degreeValue = GetTotalDegree(Degree);

            return totalPoint * degreeValue;
        }

        public abstract int GetTotalDegree(int degree);
        public abstract int GetTotalPoint(int point);
    }
}
