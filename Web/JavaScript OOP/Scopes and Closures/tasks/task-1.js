/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
	var library = (function () {
		var books = [];
		var categories = [];
		function listBooks() {
			
			return books.sort(function(a, b){return a-b});
			
		}

		function addBook(book) {
			if(book.title.length < 2 ||book.title.length > 100  ){
				throw new Error("Title must be between 2 and 100 symbols. ");
			}
			if(book.category.length < 2 ||book.category.length > 100  ){
				throw new Error("Category must be between 2 and 100 symbols. ");
			}
			if(book.author.length == 0 ){
				throw new Error('Author must not be an empty string.')
			}
			if(book.isbn.length < 10 || book.isbn.length > 13){
				throw new Error('ISBN must be between 10 or 13 digits!');
			}
			for (var everyBook in books){
				if(books[everyBook].title == book.title){
					throw new Error('Must be unique title');
				}
			}
			for (var everyBook2 in books){
				if(books[everyBook].isbn == book.isbn){
					throw new Error('Must be unique ISBN');
				}
			}
			book.title = book.title;
			book.author = book.author;
			book.ISBN = book.ISBN;
			book.category = book.category;
			book.ID = books.length + 1;
			books.push(book);
			var isThereSuchACategory = false;
			for (var everyCategory in categories){
				if(categories[everyCategory]==book.category){
					isThereSuchACategory = true;
					break;
				}
			}
			if(!isThereSuchACategory){
				categories.push(book.category);
			}
			return book;
		}

		function listCategories() {
			return categories.sort(function(a, b){return a-b});
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());
	return library;
}
module.exports = solve;
