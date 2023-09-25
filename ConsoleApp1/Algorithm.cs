namespace ConsoleApp1
{
    public class Algorithm
    {
        private readonly List<string> col;
        private  int n;
        public Algorithm(List<string> col, int n)
        {
            this.col = col;
            this.n = n;
        }

        public  string CreateId(string centerName)
        { 
            
            if (col.Contains(centerName.Substring(0, n).ToUpper()))
            {
                centerName = centerName.Substring(0, 1) + centerName;
                n++;
                CreateId(centerName);
            }
            return centerName.Substring(0, n).ToUpper();
        }

       
    }
}
