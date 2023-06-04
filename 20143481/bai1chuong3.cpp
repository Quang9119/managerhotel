#include <iostream>
using namespace std;

int main()
{
    int x,p;
    long long t=1;
    cin >> x >>p;
    for(int i=0;i<p;i++)
    {
        t*=x;
    }
    cout << t;
}
