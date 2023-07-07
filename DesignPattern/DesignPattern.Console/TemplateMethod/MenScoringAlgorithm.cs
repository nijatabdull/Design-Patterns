namespace DesignPattern.Console.TemplateMethod
{
    public class MenScoringAlgorithm : ScoringAlgorithm
    {
        public override int GetTotalDegree(int degree)
        {
            return degree * 2;
        }

        public override int GetTotalPoint(int point)
        {
            return point * 100;
        }
    }
}
