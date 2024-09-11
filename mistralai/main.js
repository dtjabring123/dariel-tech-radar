import MistralClient from '@mistralai/mistralai';

const apiKey = process.env.MISTRAL_API_KEY;
// console.log("process.env", process.env);
console.log("apiKey", apiKey);

const client = new MistralClient(apiKey);

const chatResponse = await client.chat({
  model: 'mistral-large-latest',
  messages: [{role: 'user', content: 'What is the best French cheese?'}],
});


console.log('Chat:', chatResponse.choices[0].message.content);

/**
 * Chat: Choosing the "best" French cheese can be subjective as it depends on personal taste. France is renowned for its wide variety of cheeses, with over 400 different types. Here are a few highly regarded French cheeses across various categories:

1. **Soft Cheeses:**
   - **Brie de Meaux**: Known for its creamy texture and rich, slightly nutty flavor.
   - **Camembert de Normandie**: Soft and creamy with a strong, earthy aroma.

2. **Semi-Soft Cheeses:**
   - **Morbier**: Recognizable by its layer of ash in the middle, it has a fruity and slightly nutty taste.
   - **Reblochon**: A savory cheese from the Alps with a nutty flavor and a soft, supple texture.

3. **Hard Cheeses:**
   - **Comté**: A firm, nutty, and slightly sweet cheese made from unpasteurized cow's milk.
   - **Beaufort**: Similar to Comté, it has a firm texture and a complex, nutty, and slightly sweet flavor.

4. **Blue Cheeses:**
   - **Roquefort**: A sheep milk cheese with distinctive veins of blue mold, offering a tangy and salty taste.
   - **Bleu d'Auvergne**: A cow's milk blue cheese with a strong, pungent aroma and a creamy, tangy flavor.

5. **Goat Cheeses:**
   - **Chèvre**: French goat cheese comes in many forms, but they generally have a tangy, earthy flavor.
   - **Crottin de Chavignol**: A small, round goat cheese with a dense texture and a nutty, slightly salty flavor.
 */