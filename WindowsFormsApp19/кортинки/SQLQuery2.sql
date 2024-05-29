CREATE table Nytriziolog 
(
Клиент varchar(50) not null,
Время varchar(50) not null,
Програма_Питания varchar(50) not null,
Аллергия varchar(50) not null,
Для_Кого varchar(50) not null,

)
CREATE table Klient
(
Аллергия varchar(50) not null,
Статус varchar(50) not null,
ФИО varchar(50) not null,
Номер_Телефона varchar(50) not null,
логин varchar(50) not null,
пароль varchar(50) not null,
)

CREATE table Priem
(
ФИО varchar(50) not null,
Причина varchar(50) not null,
Номер_Телефона varchar(50) not null,
Время varchar(50) not null,
)

CREATE table Laborant
(
ФИО varchar(50) not null,
Общий_анализ_крови varchar(50) not null,
Биохимический_анализ_крови varchar(50) not null,
АЛТ varchar(50) not null,
АСТ varchar(50) not null,
С_Реактивный_Белок varchar(50) not null,
Т4_Свободный varchar(50) not null,
ТТГ varchar(50) not null,
Ферритин varchar(50) not null,
Витамин_D3 varchar(50) not null,
двадцать_пять_ОН varchar(50) not null,
Витамин_B12 varchar(50) not null,
Магний varchar(50) not null,
Общий_анализ_мочи varchar(50) not null,

)
