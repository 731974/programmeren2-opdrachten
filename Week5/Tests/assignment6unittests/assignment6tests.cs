namespace Assignment5to7.Tests
{
    [TestFixture]
    public class OrderTests
    {
        [Test]
        public void Constructor_ValidParameters_PropertiesAreSet()
        {
            // Arrange
            var product = new Product("Laptop", 10, 1000);
            int quantity = 5;

            // Act
            var order = new Order(product, quantity);

            // Assert
            Assert.AreEqual(product, order.Product);
            Assert.AreEqual(quantity, order.Quantity);
        }
    }

    [TestFixture]
    public class OrderManagerTests
    {
        [Test]
        public void CheckInventoryForProductName_ProductExists_ReturnsProduct()
        {
            // Arrange
            var orderManager = new OrderManager();
            var inventory = new List<Product>
            {
                new Product("Laptop", 10, 1000),
                new Product("Mouse", 20, 20),
                new Product("Keyboard", 15, 50)
            };

            // Act
            var product = orderManager.CheckInventoryForProductName(inventory, "Mouse");

            // Assert
            Assert.IsNotNull(product);
            Assert.AreEqual("Mouse", product.Name);
        }

        [Test]
        public void CheckInventoryForProductName_ProductDoesNotExist_ThrowsKeyNotFoundException()
        {
            // Arrange
            var orderManager = new OrderManager();
            var inventory = new List<Product>
            {
                new Product("Laptop", 10, 1000),
                new Product("Mouse", 20, 20),
                new Product("Keyboard", 15, 50)
            };

            // Act & Assert
            var ex = Assert.Throws<KeyNotFoundException>(() => orderManager.CheckInventoryForProductName(inventory, "Tablet"));
            Assert.That(ex.Message, Is.EqualTo("Error: Product not found in inventory."));
        }

        [Test]
        public void ProcessOrder_ValidOrder_UpdatesStock()
        {
            // Arrange
            var orderManager = new OrderManager();
            var inventory = new List<Product>
            {
                new Product("Laptop", 10, 1000),
                new Product("Mouse", 20, 20),
                new Product("Keyboard", 15, 50)
            };
            var order = new Order(inventory[0], 5);

            // Act
            orderManager.ProcessOrder(inventory, order);

            // Assert
            Assert.AreEqual(5, inventory[0].Stock);
        }

        [Test]
        public void ProcessOrder_ProductNotInInventory_ThrowsKeyNotFoundException()
        {
            // Arrange
            var orderManager = new OrderManager();
            var inventory = new List<Product>
            {
                new Product("Laptop", 10, 1000),
                new Product("Mouse", 20, 20),
                new Product("Keyboard", 15, 50)
            };
            var order = new Order(new Product("Tablet", 5, 500), 5);

            // Act & Assert
            var ex = Assert.Throws<KeyNotFoundException>(() => orderManager.ProcessOrder(inventory, order));
            Assert.That(ex.Message, Is.EqualTo("Error: Product not found in inventory."));
        }

        [Test]
        public void ProcessOrder_InsufficientStock_ThrowsInvalidOperationException()
        {
            // Arrange
            var orderManager = new OrderManager();
            var inventory = new List<Product>
            {
                new Product("Laptop", 10, 1000),
                new Product("Mouse", 20, 20),
                new Product("Keyboard", 15, 50)
            };
            var order = new Order(inventory[0], 15);

            // Act & Assert
            var ex = Assert.Throws<InvalidOperationException>(() => orderManager.ProcessOrder(inventory, order));
            Assert.That(ex.Message, Is.EqualTo("Error: Insufficient stock."));
        }
    }

    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void DisplayInventory_ValidInventory_PrintsInventory()
        {
            // Arrange
            var program = new Program();
            var inventory = new List<Product>
            {
                new Product("Laptop", 10, 1000),
                new Product("Mouse", 20, 20),
                new Product("Keyboard", 15, 50)
            };
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            program.DisplayInventory(inventory);

            // Assert
            var output = stringWriter.ToString();
            Assert.IsTrue(output.Contains("Laptop"));
            Assert.IsTrue(output.Contains("Mouse"));
            Assert.IsTrue(output.Contains("Keyboard"));
        }

        [Test]
        public void AskForOrder_ValidProductAndQuantity_ReturnsOrder()
        {
            // Arrange
            var program = new Program();
            var inventory = new List<Product>
            {
                new Product("Laptop", 10, 1000),
                new Product("Mouse", 20, 20),
                new Product("Keyboard", 15, 50)
            };
            var input = "Laptop\n5\n";
            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            // Act
            var order = program.AskForOrder(inventory);

            // Assert
            Assert.IsNotNull(order);
            Assert.AreEqual("Laptop", order.Product.Name);
            Assert.AreEqual(5, order.Quantity);
        }

        [Test]
        public void AskForOrder_InvalidProductName_ThrowsKeyNotFoundException()
        {
            // Arrange
            var program = new Program();
            var inventory = new List<Product>
            {
                new Product("Laptop", 10, 1000),
                new Product("Mouse", 20, 20),
                new Product("Keyboard", 15, 50)
            };
            var input = "InvalidProduct\n5\n";
            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            // Act & Assert
            var ex = Assert.Throws<KeyNotFoundException>(() => program.AskForOrder(inventory));
            Assert.That(ex.Message, Is.EqualTo("Error: Product not found in inventory."));
        }

        [Test]
        public void AskForOrder_InvalidQuantity_ThrowsFormatException()
        {
            // Arrange
            var program = new Program();
            var inventory = new List<Product>
            {
                new Product("Laptop", 10, 1000),
                new Product("Mouse", 20, 20),
                new Product("Keyboard", 15, 50)
            };
            var input = "Laptop\ninvalid\n";
            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            // Act & Assert
            Assert.Throws<FormatException>(() => program.AskForOrder(inventory));
        }

        [Test]
        public void OrderProduct_ValidOrder_ProcessesOrder()
        {
            // Arrange
            var program = new Program();
            var inventory = new List<Product>
            {
                new Product("Laptop", 10, 1000),
                new Product("Mouse", 20, 20),
                new Product("Keyboard", 15, 50)
            };
            var input = "Laptop\n5\n";
            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            program.OrderProduct(inventory);

            // Assert
            Assert.AreEqual(5, inventory[0].Stock);
            var output = stringWriter.ToString();
            Assert.IsFalse(output.Contains("Error"));
        }

        [Test]
        public void OrderProduct_ProductNotInInventory_AddsLogAndPrintsError()
        {
            // Arrange
            var program = new Program();
            var inventory = new List<Product>
            {
                new Product("Laptop", 10, 1000),
                new Product("Mouse", 20, 20),
                new Product("Keyboard", 15, 50)
            };
            var input = "Tablet\n5\n";
            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            program.OrderProduct(inventory);

            // Assert
            var output = stringWriter.ToString();
            Assert.IsTrue(output.Contains("Error: Product not found in inventory."));
            Assert.IsTrue(program.logs.Contains("Error: Product not found in inventory."));
        }

        [Test]
        public void OrderProduct_InsufficientStock_AddsLogAndPrintsError()
        {
            // Arrange
            var program = new Program();
            var inventory = new List<Product>
            {
                new Product("Laptop", 10, 1000),
                new Product("Mouse", 20, 20),
                new Product("Keyboard", 15, 50)
            };
            var input = "Laptop\n15\n";
            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            program.OrderProduct(inventory);

            // Assert
            var output = stringWriter.ToString();
            Assert.IsTrue(output.Contains("Error: Insufficient stock."));
            Assert.IsTrue(program.logs.Contains("Error: Insufficient stock."));
        }
    }
}


