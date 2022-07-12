
(function solve(){
    Array.prototype.last = function(){
        return this[this.length - 1];
    }
    
    Array.prototype.skip = function(n){
        let slice = this.slice(Number(n));
    
        return slice;
    }
    
    Array.prototype.take = function(n){
        let taked = this.slice(0, Number(n));
        return taked;
    }
    
    Array.prototype.sum = function(){
        return this.reduce(function(previosValue, currentValue){
            return previosValue + currentValue;
        }, 0);
    }
    
    Array.prototype.average = function(){
        return this.sum() /  this.length;
    }
})();

