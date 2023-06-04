#include <iostream>
#include <string.h>
using namespace std;
void chuyen10sang2(int n);
void chuyen10sang8(int n);
void chuyen10sang16(int n);

int main()
{
	int n;
	cin >> n;
	chuyen10sang2(n);
	chuyen10sang8(n);
	chuyen10sang16(n);
	return 0; 
}
void chuyen10sang2(int n)
{
	int i=0;
	char S[20];
	while(n>0)
	{
		S[i++]= (n%2)+48;
		n/=2;
	}
	S[i]='\0';
	strrev(S);
	cout << S << endl;
}
void chuyen10sang8(int n)
{
	int i=0;
	char S[20];
	while(n>0)
	{
		S[i++]=(n%8)+48;
		n/=8;
	}
	S[i]='\0';
	strrev(S);
	cout << S << endl;
}
void chuyen10sang16(int n)
{
	int i=0;
	char S[20];
	while(n>0)
	{
		if(n%16<10)
		{
			S[i++]=(n%16)+48;
		}
		else
		{
			S[i++]=(n%16)+55;
		}
		n/=16;
	}
	S[i]='\0';
	strrev(S);
	cout << S << endl;
}

