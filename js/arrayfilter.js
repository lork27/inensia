const arr1 = [1, 2, 3, 4, 5];

const arr2 = [24, 20, 3, 40, 4];

const joined = arr1.concat(arr2);

const unique = [...new Set(joined)];

console.log(unique);
