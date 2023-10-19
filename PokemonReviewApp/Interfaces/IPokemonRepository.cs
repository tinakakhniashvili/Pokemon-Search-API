using PokemonReviewApp.Models;
namespace PokemonReviewApp.Interfaces
{
    public interface IPokemonRepository
    {
        public ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(string name);
        decimal CetPokemonRating(int pokeId);
        object GetPokemonRating(int pokeId);
        bool PokemonExists(int pokeId);

        bool CreatePokemon(int owneId, int categoryId, Pokemon pokemon );
        bool UpdatePokemon(int ownerId, int categoryId, Pokemon pokemon);
        bool DeletePokemon(Pokemon pokemonId);
        bool Save();

    }
}
