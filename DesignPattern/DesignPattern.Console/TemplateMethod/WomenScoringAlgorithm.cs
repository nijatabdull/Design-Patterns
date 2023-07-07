namespace DesignPattern.Console.TemplateMethod
{
    public class WomenScoringAlgorithm : ScoringAlgorithm
    {
        public override int GetTotalDegree(int degree)
        {
            return degree * 3;
        }

        public override int GetTotalPoint(int point)
        {
            return point * 150;
        }
    }
}
