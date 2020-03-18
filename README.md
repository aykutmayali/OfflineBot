# OfflineBot
 C# & OryzerStudio

## ORYZER STUDIO
-----------------
1. Dialog
2. Intent (first incoming messages)
3. Response + Context Add (first)
4. Intent (Second )+Context(mission of intent)+Expression(variable)
5. Response
6. Entry(user)

## VISUAL STUDIO
------------------
1. New .NET CONSOLE APP
2. Package Manager Console--> Install-Package Syn.Bot 
3. In Program.cs
* create new OscavaBot object
* import Oryzer file
* call objects Trainer.StartTraining function
* bot receives requests from Console and Evaluates them due to its own scenario at Oryzer File
 
 ### ORYZER
#### Dialog: Konuşma başlatma kutusu , soru ve cavapların toplandığı yer
#### Intent: Bir kullanıcı sorgusunu bir yanıta ve isteğe bağlı olarak belirli bir niyetin ifadesi (kullanıcı sorgusu örneği) eşleştiğinde bir eylemle ilişkilendiren bir şeydir
#### Expressions: Bir bot motorunun benzerlik tespiti için kalıplar bulmasına yardımcı olacak kullanıcı sorgusu örnekleri kümesidir.
#### Response: Bir kullanıcı sorgusu bir niyetle ilişkilendirilmiş bir ifadeyle eşleştiğinde çağrılan bir eylemin bir parçasıdır.
#### ContextAdd: yanıt çağrıldığında, ilgili bağlam eklenir.
#### Context (table-date-con): hiyerarşik bir konuşma akışı oluşturmak için genellikle sohbet oturumu adı verilen bir şeye eklenen bir dize etiketidir. Response Yanıt düğümünün çıkış bağlantı noktasına bağlandı, Intent /Niyet tarafından bir yanıt üretildiğinde, bu düğüm yürütülür ve oturumda bir table item date-con bağlam öğesi eklenir ve sonraki 2 kullanıcı sorgusu için mevcut olur(Lifespan sayısı 2 girildi)
