# DatingApp
https://www.udemy.com/course/build-an-app-with-aspnet-core-and-angular-from-scratch/learn/lecture/8707668?start=15#overview

DatingApp.API
```
dotnet tool install --global dotnet-ef --version 3.0.0
dotnet restore
dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet watch run
http://localhost:5000/api/values
```

Issues with migrations

```
dotnet ef database drop
dotnet ef migrations remove // delete last migration
dotnet ef database update
```

DatingApp-SPA
```
brew install node
npm install -g @angular/cli
npm install
ng serve
http://localhost:4200/
```

#### How do I unlock a SQLite database?

```
$ fuser development.db

This command will show what process is locking the file:

> development.db: 5430

Just kill the process...

kill -9 5430
```
### time-ago-pipe pipe issue
https://www.udemy.com/course/build-an-app-with-aspnet-core-and-angular-from-scratch/learn/lecture/8715292#questions/8166162
I solved the problem bu replacing the time-ago-pipe with the ngx-timeago (https://www.npmjs.com/package/ngx-timeago) as it seems to have solved the issue