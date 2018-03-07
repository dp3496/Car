namespace Car
{
    public class PalindromeRearranging
    {
        public bool IsPalindromeRearrangin(string value)
        {
            if (value.Length % 2 == 0)
            {
                foreach (var i in value)
                {
                    int count = 0;
                    foreach (var j in value)
                    {
                        if (i == j)
                        {
                            count++;
                        }
                    }

                    if (count % 2 != 0)
                        return false;
                }

                return true;
            }
            else
            {
                int tmpcount = 0;
                foreach (var i in value)
                {
                    int count = 0;
                    foreach (var j in value)
                    {
                        if (i == j)
                        {
                            count++;
                        }
                    }

                    if (count % 2 != 0)
                        tmpcount++;
                }

                if (tmpcount == 1)
                    return true;
                else
                    return false;
            }
        }
    }
}