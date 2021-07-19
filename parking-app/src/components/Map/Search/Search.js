import React from 'react';
import SearchAction from "./SearchAction/SearchAction";
import SearchContainer from "./SearchContainer/SearchContainer";

const Search = props => {

    return (
        <div>
            <SearchAction onSearchClick={props.onSearchClick}/>
            {
                props.show &&
                <SearchContainer
                    data={props.data}
                    onCloseClick={props.onCloseClick}
                    onSelectLocation={props.onClickResult}
                />
            }
        </div>
    );
};

export default Search;
