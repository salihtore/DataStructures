
void BubbleSort(int [] x)
{
    int n = x.Length;
    bool sirali = false;

    for(int i = 0; i < n-1 && !sirali; i++)
    {
        sirali = true;

        for(j = 0; j < n-i-1 ; j++)
        {
            if (x[j] > x[j + 1])
            {
                int tut = x[j];
                x[j] = x[j+1];
                x[j+1] = tut;
                sirali = false;
            }
        }
    }
}