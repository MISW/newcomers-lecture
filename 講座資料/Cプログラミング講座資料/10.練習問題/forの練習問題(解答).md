#### 1.解答
```
#include<stdio.h>

int main(){
	
	int i;
	for(i=0;i<30;i++){
		
		printf("%d\n",i);
		
	}
	
	return 0;
}
```

#### 2.解答
```
#include<stdio.h>

int main(){
	int i;
	
	for(i=1;i<30;i+=2){
		printf("%d\n",i);
	}
	
	return 0;
}
```
if文を使うと下のようにしてもできる。

```
#include<stdio.h>

int main(){
	
	int i;
	for(i=0;i<30;i++){
		if(i%2==1){
			printf("%d\n",i);
		}
	}
	
	return 0;
}
```

#### 3.解答
```
#include<stdio.h>

int main(){
	int i,j;
	
	for(i=1;i<=9;i++){
		
		for(j=1;j<=9;j++){
			printf("%d * %d = %d\n",i,j,i*j);
		}
		
	}
	
	return 0;
}
```
#### 4.解答
```
#include<stdio.h>

int main(){
	
	int i;
	
	for(i=1;i<=100;i++){
		
		if(i%15==0){
			printf("FizzBuzz\n");
		}
		else if(i%3 == 0){
			printf("Fizz\n");
		}
		else if(i%5 == 0){
			printf("Buzz\n");
		}
		else{
			printf("%d\n",i);
		}
		
	}
	
	return 0;
}
```

#### 5.解答
素数の判定はいろいろなアルゴリズムがあるが、一番簡単なのは、受け取った数を2,3,4・・・と順々に割っていき、最後まで割り切れなかったら素数、割りきれてしまったら素数ではない。  
とする。例えば
13を受け取ったとしたら、  
13÷2は割り切れない。  
13÷3は割り切れない。  
・・・  
と繰り返していき、  
13÷12までひたすらループでやっていく。  
割り切れるかどうかは % を用いた余りを見るとよい.  
```

#include<stdio.h>

int main(){
	
	//iがループカウンタ,nが受け取った数を保存する場所,
	//stateが割り切れるかどうかのスイッチ。
	//割り切れたらstateを1に、割り切れなかったらstateを0のままに。
	int i,n,state=0;
	
	printf("自然数を一つ入力してください。\n");
	scanf("%d",&n);
	
	//受け取った数が1の時のみ例外処理。
	if(n==1){
		printf("%dは素数ではありません。\n");
	}
	
	else{
		for(i=2;i<n;i++){
			
			//1回でも割り切れたらこれ以上の計算は不要なので、ループを抜け出す。
			if(n % i == 0){
				state=1;
				break;
			}
			
		}
		
	}
	//1回も割り切れてなかったら、素数。
	if(state == 0){
		printf("%dは素数です。\n",n);
	}
	//割りきれてしまってたら素数ではない。
	else{
		printf("%dは素数ではありません。\n",n);
	}
	
	return 0;
	
}
```