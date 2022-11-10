using BookShop.Model;

namespace BookModelTests
{
    public class Story1Tests
    {
        // 1. Code the test to validate only the specific requirements.
        // 2. Verify that you can’t compile (because the code you want to test doesn’t exist yet).
        // 3. Implement just enough code (a stub/empty class) to make the code compile.
        // 4. Verify that your test fails
        // 5. Only implement just enough code to make the test pass.

        // Suggested tests
        // * Make a store that contains at least three different books with the following attributes: ISBN(string),
        //   title(text), author(text), price(positive number), number on stock(zero, or positive)
        // * Add a book with invalid values(ISBN/Title/etc.) and make sure the collection throws an ArgumentException

        [Fact]
        public void TestCreateStoreWithBooks()
        {
            // Arrange
            Store store = new();
            Book book1 = new(Title: "Harry Potter 1", Author: "J.K. Rowling", ISBN: "1234-12342-244");
            Book book2 = new("Harry Potter 2", "J.K. Rowling", "1234-12342-245");
            Book book3 = new("Harry Potter 3", "J.K. Rowling", "1234-12342-246");

            // Act
            store.Add(book1, 4);
            store.Add(book2, 4);
            store.Add(book3, 10);

            //Assert
            Assert.Equal(18, store.BookCount());
        }
    }
}