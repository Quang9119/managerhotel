#include <iostream>
using namespace std;
int tinhgiatri(int A[][104], int m, int n);

int main()
{
    int m, n;
    int A[104][104];
    cin >> m >> n;
    for (int i = 1; i <= m; i++)
    {
        for (int j = 1; j <= n; j++)
        {
            
            {
                cin  >>  A[i][j];
            }
        }
    }
    int tong = tinhgiatri(A, m, n);
    cout << tong;
    
    return 0;
}
int X[8] = {0, -1, 0, -1, 0, 1, 2, 1};
int Y[8] = {-2, -1, -2, 1, 2, -1, 0, 1};

bool lalom(int A[][104], int i, int j, int m, int n)
{
    for (int k = 0; k < 8; k++)
    {
        int newX = i + X[k];
        int newY = j + Y[k];
        
        if (newX >= 1 && newX <= m && newY >= 1 && newY <= n && A[i][j] >= A[newX][newY])
        {
            return false;
        }
    }
    return true;
}

int tinhgiatri(int A[][104], int m, int n)
{
    int tong = 0;
    for (int j = 0; j <= n+1; j++)
    {
        A[0][j] = 99999;
        A[m+1][j] = 99999;
    }
    for (int i = 0; i <= m+1; i++)
    {
        A[i][0] = 99999;
        A[i][n+1] = 99999;
    }
	
    for (int i = 0; i <= m+1; i++)
    {
        for (int j = 0; j <= n+1; j++)
        {
            
            {
                if(lalom(A,i,j,m,n)) tong+=A[i][j];
            }
        }
    }
    return tong;
}




