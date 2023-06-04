#include <iostream>
using namespace std;
void ve(int n);
int main()
{
	int n;
	cin >>n;
	ve(n);
	return 0;
	
}
int tohop(int k,int n)
{
	if(k==0||k==n)
	{
		return 1;
	}
	if(k==1)
	{
		return n;
	}
}
void ve(int n)
{
	for(int i=0;i<n;i++)
	{
		for(int j=n;j>i;j--)
		{
			
			cout << " ";
		}
		for(int j=0;j<=i;j++)
		{
			cout << tohop(j,i) << " ";
		}
		cout << endl;
	}
}
