package com.microsoft;

import java.util.Comparator;

/**
 * Created by mmelusky on 10/10/2015.
 */
public class PersonComparator implements Comparator<Person> {
    @Override
    public int compare(Person o1, Person o2) {
        return o1.getName().compareTo(o2.getName());
    }
}
