#include <iostream>
using namespace std;
int tinh(int A);

int main()
{
	int A;
	cin >> A;
	int n = tinh(A);
	cout << n;
	return 0;
}
int tinh(int A)
{
	long double tong =0;
	int i=1;
	while(tong<=A)
	{
		tong+=(double)1/i;
		i++;
	}
	return i-1;
}
