using DryCleaner.Domain.Entities;
using DryCleaner.Domain.Enums;

namespace DryCleaner.Domain.Data;

/// <summary>
/// Набор тестовых данных 
/// </summary>
public static class DataSeed
{
    public static List<ProductCategory> Categories { get; } =
    [
        new ProductCategory
        {
            Id = 1,
            Name = "Верхняя одежда",
            RecommendedCleaningType = "Химчистка",
            CleaningPrice = 1500m
        },
        new ProductCategory
        {
            Id = 2,
            Name = "Костюмы",
            RecommendedCleaningType = "Химчистка",
            CleaningPrice = 1200m
        },
        new ProductCategory
        {
            Id = 3,
            Name = "Платья",
            RecommendedCleaningType = "Деликатная чистка",
            CleaningPrice = 1000m
        },
        new ProductCategory
        {
            Id = 4,
            Name = "Рубашки",
            RecommendedCleaningType = "Стирка",
            CleaningPrice = 500m
        },
        new ProductCategory
        {
            Id = 5,
            Name = "Брюки",
            RecommendedCleaningType = "Химчистка",
            CleaningPrice = 700m
        },
        new ProductCategory
        {
            Id = 6,
            Name = "Пальто",
            RecommendedCleaningType = "Химчистка",
            CleaningPrice = 1800m
        },
        new ProductCategory
        {
            Id = 7,
            Name = "Куртки",
            RecommendedCleaningType = "Химчистка",
            CleaningPrice = 1300m
        },
        new ProductCategory
        {
            Id = 8,
            Name = "Шторы",
            RecommendedCleaningType = "Деликатная чистка",
            CleaningPrice = 2000m
        },
        new ProductCategory
        {
            Id = 9,
            Name = "Одеяла",
            RecommendedCleaningType = "Стирка",
            CleaningPrice = 1700m
        },
        new ProductCategory
        {
            Id = 10,
            Name = "Обувь",
            RecommendedCleaningType = "Специальная чистка",
            CleaningPrice = 900m
        }
    ];

    public static List<Client> Clients { get; } =
    [
        new Client { Id = 1, Name = "Иванов Иван Иванович", Phone = "+79990000001" },
        new Client { Id = 2, Name = "Петров Петр Петрович", Phone = "+79990000002" },
        new Client { Id = 3, Name = "Сидорова Анна Сергеевна", Phone = "+79990000003" },
        new Client { Id = 4, Name = "Кузнецов Алексей Владимирович", Phone = "+79990000004" },
        new Client { Id = 5, Name = "Смирнова Елена Андреевна", Phone = "+79990000005" },
        new Client { Id = 6, Name = "Попов Дмитрий Сергеевич", Phone = "+79990000006" },
        new Client { Id = 7, Name = "Васильева Ольга Николаевна", Phone = "+79990000007" },
        new Client { Id = 8, Name = "Новиков Андрей Павлович", Phone = "+79990000008" },
        new Client { Id = 9, Name = "Морозова Мария Игоревна", Phone = "+79990000009" },
        new Client { Id = 10, Name = "Волков Сергей Александрович", Phone = "+79990000010" },
        new Client { Id = 11, Name = "Федорова Наталья Викторовна", Phone = "+79990000011" },
        new Client { Id = 12, Name = "Алексеев Максим Олегович", Phone = "+79990000012" },
        new Client { Id = 13, Name = "Павлова Екатерина Романовна", Phone = "+79990000013" },
        new Client { Id = 14, Name = "Семенов Артем Ильич", Phone = "+79990000014" },
        new Client { Id = 15, Name = "Голубева Виктория Денисовна", Phone = "+79990000015" },
        new Client { Id = 16, Name = "Виноградов Николай Петрович", Phone = "+79990000016" },
        new Client { Id = 17, Name = "Беляева Ирина Михайловна", Phone = "+79990000017" },
        new Client { Id = 18, Name = "Тарасов Роман Евгеньевич", Phone = "+79990000018" },
        new Client { Id = 19, Name = "Жукова Дарья Андреевна", Phone = "+79990000019" },
        new Client { Id = 20, Name = "Орлов Михаил Сергеевич", Phone = "+79990000020" }
    ];

    public static List<Product> Products { get; } =
    [
        new Product { Id = 1, Name = "Пальто классическое", Material = "Шерсть", Category = Categories[5] },
        new Product { Id = 2, Name = "Куртка зимняя", Material = "Полиэстер", Category = Categories[6] },
        new Product { Id = 3, Name = "Костюм мужской", Material = "Шерсть", Category = Categories[1] },
        new Product { Id = 4, Name = "Платье вечернее", Material = "Шёлк", Category = Categories[2] },
        new Product { Id = 5, Name = "Рубашка белая", Material = "Хлопок", Category = Categories[3] },
        new Product { Id = 6, Name = "Брюки классические", Material = "Шерсть", Category = Categories[4] },
        new Product { Id = 7, Name = "Шторы длинные", Material = "Лён", Category = Categories[7] },
        new Product { Id = 8, Name = "Одеяло зимнее", Material = "Шерсть", Category = Categories[8] },
        new Product { Id = 9, Name = "Туфли кожаные", Material = "Кожа", Category = Categories[9] },
        new Product { Id = 10, Name = "Пальто женское", Material = "Кашемир", Category = Categories[5] },
        new Product { Id = 11, Name = "Куртка кожаная", Material = "Кожа", Category = Categories[6] },
        new Product { Id = 12, Name = "Костюм женский", Material = "Шерсть", Category = Categories[1] },
        new Product { Id = 13, Name = "Платье летнее", Material = "Хлопок", Category = Categories[2] },
        new Product { Id = 14, Name = "Рубашка синяя", Material = "Лён", Category = Categories[3] },
        new Product { Id = 15, Name = "Брюки женские", Material = "Хлопок", Category = Categories[4] },
        new Product { Id = 16, Name = "Шторы короткие", Material = "Лён", Category = Categories[7] },
        new Product { Id = 17, Name = "Одеяло летнее", Material = "Хлопок", Category = Categories[8] },
        new Product { Id = 18, Name = "Кроссовки", Material = "Текстиль", Category = Categories[9] },
        new Product { Id = 19, Name = "Пальто мужское", Material = "Кашемир", Category = Categories[5] },
        new Product { Id = 20, Name = "Куртка демисезонная", Material = "Полиэстер", Category = Categories[6] },
        new Product { Id = 21, Name = "Костюм деловой", Material = "Шерсть", Category = Categories[1] },
        new Product { Id = 22, Name = "Платье коктейльное", Material = "Шёлк", Category = Categories[2] },
        new Product { Id = 23, Name = "Рубашка чёрная", Material = "Хлопок", Category = Categories[3] },
        new Product { Id = 24, Name = "Брюки спортивные", Material = "Полиэстер", Category = Categories[4] },
        new Product { Id = 25, Name = "Шторы декоративные", Material = "Бархат", Category = Categories[7] },
        new Product { Id = 26, Name = "Одеяло детское", Material = "Хлопок", Category = Categories[8] },
        new Product { Id = 27, Name = "Ботинки кожаные", Material = "Кожа", Category = Categories[9] },
        new Product { Id = 28, Name = "Пальто осеннее", Material = "Шерсть", Category = Categories[5] },
        new Product { Id = 29, Name = "Куртка спортивная", Material = "Полиэстер", Category = Categories[6] },
        new Product { Id = 30, Name = "Костюм классический", Material = "Шерсть", Category = Categories[1] }
    ];

    public static List<Order> Orders { get; } =
    [
        // Иванов — 8 заказов
        new Order { Id = 1, Client = Clients[0], Product = Products[0], AcceptedAt = new DateTime(2025, 1, 15), ProcessingDays = 5, Status = OrderStatus.Issued },
        new Order { Id = 2, Client = Clients[0], Product = Products[3], AcceptedAt = new DateTime(2025, 3, 10), ProcessingDays = 7, Status = OrderStatus.Issued },
        new Order { Id = 3, Client = Clients[0], Product = Products[4], AcceptedAt = new DateTime(2025, 5, 20), ProcessingDays = 3, Status = OrderStatus.Issued },
        new Order { Id = 4, Client = Clients[0], Product = Products[5], AcceptedAt = new DateTime(2025, 8, 12), ProcessingDays = 4, Status = OrderStatus.Issued },
        new Order { Id = 5, Client = Clients[0], Product = Products[7], AcceptedAt = new DateTime(2025, 11, 5), ProcessingDays = 10, Status = OrderStatus.Issued },
        new Order { Id = 6, Client = Clients[0], Product = Products[18], AcceptedAt = new DateTime(2026, 1, 20), ProcessingDays = 15, Status = OrderStatus.InProgress },
        new Order { Id = 7, Client = Clients[0], Product = Products[24], AcceptedAt = new DateTime(2026, 3, 5), ProcessingDays = 6, Status = OrderStatus.Ready },
        new Order { Id = 8, Client = Clients[0], Product = Products[28], AcceptedAt = new DateTime(2026, 5, 18), ProcessingDays = 8, Status = OrderStatus.InProgress },

        // Петров — 7 заказов
        new Order { Id = 9, Client = Clients[1], Product = Products[1], AcceptedAt = new DateTime(2025, 2, 10), ProcessingDays = 4, Status = OrderStatus.Issued },
        new Order { Id = 10, Client = Clients[1], Product = Products[2], AcceptedAt = new DateTime(2025, 4, 15), ProcessingDays = 6, Status = OrderStatus.Issued },
        new Order { Id = 11, Client = Clients[1], Product = Products[5], AcceptedAt = new DateTime(2025, 6, 20), ProcessingDays = 3, Status = OrderStatus.Issued },
        new Order { Id = 12, Client = Clients[1], Product = Products[6], AcceptedAt = new DateTime(2025, 9, 1), ProcessingDays = 9, Status = OrderStatus.Issued },
        new Order { Id = 13, Client = Clients[1], Product = Products[11], AcceptedAt = new DateTime(2025, 12, 15), ProcessingDays = 7, Status = OrderStatus.Issued },
        new Order { Id = 14, Client = Clients[1], Product = Products[20], AcceptedAt = new DateTime(2026, 2, 10), ProcessingDays = 5, Status = OrderStatus.Ready },
        new Order { Id = 15, Client = Clients[1], Product = Products[22], AcceptedAt = new DateTime(2026, 4, 12), ProcessingDays = 11, Status = OrderStatus.InProgress },

        // Сидорова — 6 заказов
        new Order { Id = 16, Client = Clients[2], Product = Products[3], AcceptedAt = new DateTime(2025, 1, 25), ProcessingDays = 8, Status = OrderStatus.Issued },
        new Order { Id = 17, Client = Clients[2], Product = Products[12], AcceptedAt = new DateTime(2025, 5, 10), ProcessingDays = 12, Status = OrderStatus.Issued },
        new Order { Id = 18, Client = Clients[2], Product = Products[13], AcceptedAt = new DateTime(2025, 7, 15), ProcessingDays = 5, Status = OrderStatus.Issued },
        new Order { Id = 19, Client = Clients[2], Product = Products[21], AcceptedAt = new DateTime(2025, 10, 20), ProcessingDays = 16, Status = OrderStatus.Issued },
        new Order { Id = 20, Client = Clients[2], Product = Products[25], AcceptedAt = new DateTime(2026, 1, 10), ProcessingDays = 18, Status = OrderStatus.InProgress },
        new Order { Id = 21, Client = Clients[2], Product = Products[8], AcceptedAt = new DateTime(2026, 5, 5), ProcessingDays = 10, Status = OrderStatus.Ready },

        // Кузнецов — 5 заказов
        new Order { Id = 22, Client = Clients[3], Product = Products[2], AcceptedAt = new DateTime(2025, 2, 5), ProcessingDays = 5, Status = OrderStatus.Issued },
        new Order { Id = 23, Client = Clients[3], Product = Products[4], AcceptedAt = new DateTime(2025, 6, 12), ProcessingDays = 3, Status = OrderStatus.Issued },
        new Order { Id = 24, Client = Clients[3], Product = Products[9], AcceptedAt = new DateTime(2025, 11, 1), ProcessingDays = 20, Status = OrderStatus.Issued },
        new Order { Id = 25, Client = Clients[3], Product = Products[19], AcceptedAt = new DateTime(2026, 2, 25), ProcessingDays = 17, Status = OrderStatus.Ready },
        new Order { Id = 26, Client = Clients[3], Product = Products[23], AcceptedAt = new DateTime(2026, 7, 1), ProcessingDays = 9, Status = OrderStatus.InProgress },

        // Смирнова — 4 заказа
        new Order { Id = 27, Client = Clients[4], Product = Products[3], AcceptedAt = new DateTime(2025, 3, 15), ProcessingDays = 6, Status = OrderStatus.Issued },
        new Order { Id = 28, Client = Clients[4], Product = Products[4], AcceptedAt = new DateTime(2025, 8, 5), ProcessingDays = 4, Status = OrderStatus.Issued },
        new Order { Id = 29, Client = Clients[4], Product = Products[6], AcceptedAt = new DateTime(2025, 12, 1), ProcessingDays = 8, Status = OrderStatus.Issued },
        new Order { Id = 30, Client = Clients[4], Product = Products[15], AcceptedAt = new DateTime(2026, 3, 20), ProcessingDays = 10, Status = OrderStatus.Ready },

        // Попов — 3 заказа
        new Order { Id = 31, Client = Clients[5], Product = Products[0], AcceptedAt = new DateTime(2025, 4, 1), ProcessingDays = 7, Status = OrderStatus.Issued },
        new Order { Id = 32, Client = Clients[5], Product = Products[10], AcceptedAt = new DateTime(2025, 7, 10), ProcessingDays = 11, Status = OrderStatus.Issued },
        new Order { Id = 33, Client = Clients[5], Product = Products[17], AcceptedAt = new DateTime(2026, 1, 25), ProcessingDays = 13, Status = OrderStatus.Ready },

        // Васильева — 3 заказа
        new Order { Id = 34, Client = Clients[6], Product = Products[4], AcceptedAt = new DateTime(2025, 5, 1), ProcessingDays = 3, Status = OrderStatus.Issued },
        new Order { Id = 35, Client = Clients[6], Product = Products[5], AcceptedAt = new DateTime(2025, 9, 15), ProcessingDays = 5, Status = OrderStatus.Issued },
        new Order { Id = 36, Client = Clients[6], Product = Products[12], AcceptedAt = new DateTime(2026, 2, 5), ProcessingDays = 9, Status = OrderStatus.InProgress },

        // Новиков — 3 заказа
        new Order { Id = 37, Client = Clients[7], Product = Products[1], AcceptedAt = new DateTime(2025, 6, 5), ProcessingDays = 8, Status = OrderStatus.Issued },
        new Order { Id = 38, Client = Clients[7], Product = Products[7], AcceptedAt = new DateTime(2025, 10, 15), ProcessingDays = 14, Status = OrderStatus.Issued },
        new Order { Id = 39, Client = Clients[7], Product = Products[18], AcceptedAt = new DateTime(2026, 3, 10), ProcessingDays = 19, Status = OrderStatus.Ready },

        // Морозова — 2 заказа
        new Order { Id = 40, Client = Clients[8], Product = Products[2], AcceptedAt = new DateTime(2025, 7, 1), ProcessingDays = 5, Status = OrderStatus.Issued },
        new Order { Id = 41, Client = Clients[8], Product = Products[3], AcceptedAt = new DateTime(2026, 1, 15), ProcessingDays = 12, Status = OrderStatus.InProgress },

        // Волков — 2 заказа
        new Order { Id = 42, Client = Clients[9], Product = Products[5], AcceptedAt = new DateTime(2025, 8, 20), ProcessingDays = 6, Status = OrderStatus.Issued },
        new Order { Id = 43, Client = Clients[9], Product = Products[6], AcceptedAt = new DateTime(2026, 2, 15), ProcessingDays = 8, Status = OrderStatus.Ready },

        // Федорова — 2 заказа
        new Order { Id = 44, Client = Clients[10], Product = Products[8], AcceptedAt = new DateTime(2025, 9, 10), ProcessingDays = 9, Status = OrderStatus.Issued },
        new Order { Id = 45, Client = Clients[10], Product = Products[16], AcceptedAt = new DateTime(2026, 3, 25), ProcessingDays = 17, Status = OrderStatus.InProgress },

        // Алексеев — 2 заказа
        new Order { Id = 46, Client = Clients[11], Product = Products[9], AcceptedAt = new DateTime(2025, 11, 20), ProcessingDays = 15, Status = OrderStatus.Issued },
        new Order { Id = 47, Client = Clients[11], Product = Products[17], AcceptedAt = new DateTime(2026, 4, 20), ProcessingDays = 20, Status = OrderStatus.InProgress },

        // Павлова — 1 заказ
        new Order { Id = 48, Client = Clients[12], Product = Products[10], AcceptedAt = new DateTime(2026, 5, 10), ProcessingDays = 18, Status = OrderStatus.InProgress },

        // Семенов — 1 заказ
        new Order { Id = 49, Client = Clients[13], Product = Products[14], AcceptedAt = new DateTime(2026, 6, 10), ProcessingDays = 4, Status = OrderStatus.Ready },

        // Голубева — 1 заказ
        new Order { Id = 50, Client = Clients[14], Product = Products[22], AcceptedAt = new DateTime(2026, 7, 20), ProcessingDays = 9, Status = OrderStatus.InProgress }
    ];
}