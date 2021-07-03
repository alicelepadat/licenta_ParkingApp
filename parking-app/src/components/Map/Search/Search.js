import React, {useState} from 'react';
import SearchAction from "./SearchAction/SearchAction";
import SearchContainer from "./SearchContainer/SearchContainer";

const Search = props => {
    const [showSearchContainer, setShowSearchContainer] = useState(false);

    const handleSearchClick = () => {
        setShowSearchContainer(true);
    }

    const handleCloseClick = () => {
        setShowSearchContainer(false);
    }

    return (
        <div>
            <SearchAction onSearchClick={handleSearchClick}/>
            {
                showSearchContainer &&
                <SearchContainer
                    onCloseClick={handleCloseClick}
                />
            }
        </div>
    );
};

export default Search;
