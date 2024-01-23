# SpaceShip
במשימה זו ביצעתי את ההוספות הבאות למשחק:

1.  השחקן לא יכול לירות לייזרים בלי הפסקה, אלא חייב לחכות זמן מסוים בין ירייה 
לירייה הבאה.

תחילה הגדרתי את המשתנים הבאים בקובץ clickSpawner.cs:

![image](https://github.com/AdiNahmias/SpaceShip/assets/118722490/6fc44e48-db32-421c-aa37-6c2c175004f4)

לאחר מכן, ב-start() איתחלתי את הזמן מהירייה האחרונה להיות הזמן המסויים בין ירייה לירייה:

![image](https://github.com/AdiNahmias/SpaceShip/assets/118722490/e9b9ebcf-7370-42a9-b2a2-b2fa08b015e8)

וב-update() בכל פעם נעדכן את הזמן מאז הירייה האחרונה, ורק כאשר הזמן מאז הירייה האחרונה גדול מזמן השהייה (וכמובן כאשבר השחקן לחץ "space") תוכל להתבצע ירייה נוספת:

![image](https://github.com/AdiNahmias/SpaceShip/assets/118722490/23366e89-df16-4db5-8ecf-b9693dff8588)

בשורה האחרונה בקוד המצורף נאפס את הזמן מאז הירייה האחרונה, שכן לפני שורה זו התבצעה הירייה האחרונה.

2. בכל ירייה שיבצע השחקן יישמע סאונד של קרן לייזר.

תחילה הגדרתי את המשתנה הבא בקובץ clickSpawner.cs:

![image](https://github.com/AdiNahmias/SpaceShip/assets/118722490/6c3ce006-c924-4d8c-8cc3-329a14664c18)

לאחר מכן, לפני כל ירייה ביצעתי את הפונקצייה play() להפעלת הסאונד:

![image](https://github.com/AdiNahmias/SpaceShip/assets/118722490/5862eac5-0ff5-4aee-82d2-f44d3797d9fc)

וב-Unity הוספתי Audio Source, שאותו גררתי ל-shoot sound שהגדרתי בקוד:

![image](https://github.com/AdiNahmias/SpaceShip/assets/118722490/e15bcad3-029b-43f6-9f27-59cbbb429498)



על מנת לשחק במשחק [click here](https://adinahmias.itch.io)
