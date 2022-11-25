#include <iostream>

using namespace std;

int main()
{
   double b1 = 100, b2,b3,n;
   cin >> n;
   for(int i = 1; i <= n; i++){
       b2 = b1/10;
       b3 = b2 + 10;
       b1 = b3;
   }
   cout << b3;
}



#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    int f = 1;
    int n=1,x;
    double s = 0;
    cin >> n >> x;
    for(int i = 1; i <=n; i++){
        s+=(pow((-1),i - 1) * pow(x,2*i))/(2*f);
        f*=(f+ 1);
    }

    cout << s << endl;
    return 0;
}
