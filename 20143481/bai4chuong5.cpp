#include <iostream>
using namespace std;
void batbit(int &n,int k);
void tatbit(int &n,int k);
int laybit(int &n,int k);

int main() {
	int n,k;
    cin >> n >>k;
    batbit(n,k);
    cout << n << endl;
    tatbit(n,k);
    cout << n << endl;
    int bit = laybit(n,k);
    cout << bit << endl;
    return 0;
}
void batbit(int &n,int k)
{
	n=n |(0x1 << k);
}
void tatbit(int &n,int k)
{
	n=n&(~(0x1<<k));
}
int laybit(int &n,int k)
{
	return (n>>k) & 0x1;
}

