#include <iostream>
#include <stdlib.h>
#include <string.h>
 
bool WriteFile();
bool SplitFile();
 
#define MAX_LEN 100
 
int main()
{
    if (!WriteFile())
    {
        goto EXIT;
    }
    if (!SplitFile())
    {
        goto EXIT;
    }
    printf("\nThanh Cong");
EXIT:
    ;
return 0;
}
bool WriteFile()
{
    FILE *fp = NULL;
    int idx;
    int buff[MAX_LEN];
    fp = fopen("SONGUYEN.INP", "wb");
    if (!fp)
    {
        return false;
    }
    for (idx = 0; idx < MAX_LEN; idx++)
    {
        buff[idx] = rand();
    }
    if (fwrite(buff, sizeof(buff), 1, fp) < 1)
    {
        fclose(fp);
        return false;
    }
    fclose(fp);
    return true;
}
bool SplitFile()
{
    FILE *fp;
    FILE *fpOdd, *fpEven;
    int arr[MAX_LEN];
    int idx;
    fp = fopen("SONGUYEN.INP", "rb");
    if (!fp)
    {
        return false;
    }
    if (fread(arr, MAX_LEN*sizeof(int), 1, fp) < 1)
    {
        fclose(fp);
        return false;
    }
    fclose(fp);
    fpOdd = fopen("SOLE.OUT", "w");
    if (!fpOdd)
    {
        return false;
    }
    fpEven = fopen("SOCHAN.OUT", "w");
    if (!fpEven)
    {
        return false;
    }
    for (idx = 0; idx < MAX_LEN; idx++)
    {
        if (arr[idx]%2 == 0)
        {
            fprintf(fpEven, "%d\t", arr[idx]);
        }
        else
        {
            fprintf(fpOdd, "%d\t", arr[idx]);
        }
    }
    fclose(fpOdd);
    fclose(fpEven);
    return true;
}
