#include <iostream>
using namespace std;

int main() {
	int  n;
	cin >>  n;
	int a[n][n];
	int dong = n, cot = n, k = 1, p = 0, i, j;
	while(k <= n*n){
		for(i = p; i < cot; i++) /*Loop to access the first row of the array*/
			a[p][i] = k++;
		for(i = p+1; i < dong; i++) /*Loop tp access the last column of the array*/
			a[i][cot-1] = k++;
		if ( p != dong-1){
			for(i = cot-2; i >=p; i--) /*Loop to access the last row of the array*/
				a[dong-1][i] = k++;
		}	
		if(p!=cot-1){
			for(i = dong-2; i > p; i--) /*Loop to access the first column of the array*/
				a[i][p] = k++;
		}	
		p++;dong --; cot --;
	}
	for(i = 0; i < n; i++){
		for(j = 0; j < n; j++)
			cout << a[i][j] << " ";
		cout << endl;
	}
}
