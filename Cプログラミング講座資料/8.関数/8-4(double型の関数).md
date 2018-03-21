```
#include<stdio.h>

double function(double x){
	
	return x*x*x;
	
}

int main(){
	
	double num = function(1.25);
	
	printf("%f\n",num);
	
	return 0;
	
}
```
double functionという関数を作りました。  
なんとなく想像着くかと思いますが、今回はfunctionが小数の値を返せる状態になっています。  
そして、引数もdoubleにしましたが、関数の型と引数の型を一致させる必要はありません。  
なので今回引数をint xにすることも可能です。  