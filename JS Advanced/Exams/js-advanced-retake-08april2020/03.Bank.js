class Bank {
    constructor(bankName) {
        this._bankName = bankName;
        this.allCustomers = [];
    }

    newCustomer(customer) {
        let { firstName, lastName, personalId } = customer;

        if (this.allCustomers.find(x => x.personalId == personalId)) {
            throw new Error(`${firstName} ${lastName} is already our customer!`);
        }

        this.allCustomers.push(customer);

        return customer;
    }

    depositMoney(personalId, amount) {
        let customer = this.allCustomers.find(x => x.personalId == personalId)
        if (customer == undefined) {
            throw new Error('We have no customer with this ID!');
        }

        if (!customer.hasOwnProperty('totalMoney')) {
            customer.totalMoney = 0;
            customer.transactions = [];
        }

        customer.totalMoney += amount;
        customer.transactions.push(`${customer.firstName} ${customer.lastName} made deposit of ${amount}$!`);

        return `${customer.totalMoney}$`;
    }

    withdrawMoney(personalId, amount) {
        let customer = this.allCustomers.find(x => x.personalId == personalId)
        if (customer == undefined) {
            throw new Error('We have no customer with this ID!');
        }

        if(customer.totalMoney < amount){
            throw new Error(`${customer.firstName} ${customer.lastName} does not have enough money to withdraw that amount!`)
        }

        customer.totalMoney -= amount;
        customer.transactions.push(`${customer.firstName} ${customer.lastName} withdrew ${amount}$!`);

        return `${customer.totalMoney}$`;

    }

    customerInfo (personalId){
        let customer = this.allCustomers.find(x => x.personalId == personalId);
        if (customer == undefined) {
            throw new Error('We have no customer with this ID!');
        }

        let result = [];

        result.push(`Bank name: ${this._bankName}`);
        result.push(`Customer name: ${customer.firstName} ${customer.lastName}`);
        result.push(`Customer ID: ${customer.personalId}`);
        result.push(`Total Money: ${customer.totalMoney}$`);
        result.push(`Transactions:`);

        for (let index = customer.transactions.length - 1; index >= 0; index--) {
            result.push(`${index + 1}. ${customer.transactions[index]}`);
        }

        return result.join('\n');
    }
}